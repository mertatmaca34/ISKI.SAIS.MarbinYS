using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class MailViewModel : ObservableObject
{
    private readonly IMailSettingsService _mailSettingsService;
    private readonly IMailAlarmService _mailAlarmService;
    private const int DefaultUserId = 1;

    public MailViewModel(IMailSettingsService mailSettingsService, IMailAlarmService mailAlarmService)
    {
        _mailSettingsService = mailSettingsService;
        _mailAlarmService = mailAlarmService;

        Alarms = new ObservableCollection<MailAlarmDto>();
        Settings = new MailSettingsDto
        {
            SmtpHost = string.Empty,
            SmtpPort = 25,
            SmtpUser = string.Empty,
            SmtpPassword = string.Empty,
            SenderEmail = string.Empty,
            SenderName = string.Empty,
        };

        LoadCommand = new AsyncRelayCommand(LoadAsync);
        SaveSettingsCommand = new AsyncRelayCommand(SaveSettingsAsync, CanSaveSettings);
        ToggleAlarmCommand = new AsyncRelayCommand<MailAlarmDto>(ToggleAlarmAsync);
    }

    [ObservableProperty]
    private MailSettingsDto settings;

    partial void OnSettingsChanged(MailSettingsDto value)
    {
        OnPropertyChanged(nameof(SmtpPortValue));
    }

    [ObservableProperty]
    private string statusMessage = "Posta ayarları yüklenmedi.";

    [ObservableProperty]
    private bool isBusy;

    public ObservableCollection<MailAlarmDto> Alarms { get; }

    public IAsyncRelayCommand LoadCommand { get; }

    public IAsyncRelayCommand SaveSettingsCommand { get; }

    public IAsyncRelayCommand<MailAlarmDto> ToggleAlarmCommand { get; }

    public double SmtpPortValue
    {
        get => Settings?.SmtpPort ?? 0;
        set
        {
            if (Settings is null)
            {
                return;
            }

            var port = (int)Math.Round(value);
            if (Settings.SmtpPort != port)
            {
                Settings.SmtpPort = port;
                OnPropertyChanged(nameof(SmtpPortValue));
            }
        }
    }

    private bool CanSaveSettings()
    {
        return !IsBusy;
    }

    partial void OnIsBusyChanged(bool value)
    {
        SaveSettingsCommand.NotifyCanExecuteChanged();
    }

    private async Task LoadAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Mail ayarları yükleniyor...";

            var settings = await _mailSettingsService.GetFirstAsync();
            if (settings is not null)
            {
                Settings = settings;
            }

            var alarms = await _mailAlarmService.GetListAsync(DefaultUserId);
            Alarms.Clear();
            if (alarms is not null)
            {
                foreach (var alarm in alarms.OrderBy(a => a.Name))
                {
                    Alarms.Add(alarm);
                }
            }

            StatusMessage = "Mail ayarları güncellendi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Mail ayarları alınamadı: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task SaveSettingsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Mail ayarları kaydediliyor...";

            if (Settings.Id == 0)
            {
                var created = await _mailSettingsService.CreateAsync(new CreateMailSettingsCommand(
                    Settings.SmtpHost,
                    Settings.SmtpPort,
                    Settings.SmtpUser,
                    Settings.SmtpPassword,
                    Settings.UseSsl,
                    Settings.SenderEmail,
                    Settings.SenderName,
                    Settings.UseDefaultCredentials));

                if (created is not null)
                {
                    Settings = created;
                }
            }
            else
            {
                var updated = await _mailSettingsService.UpdateAsync(new UpdateMailSettingsCommand(
                    Settings.Id,
                    Settings.SmtpHost,
                    Settings.SmtpPort,
                    Settings.SmtpUser,
                    Settings.SmtpPassword,
                    Settings.UseSsl,
                    Settings.SenderEmail,
                    Settings.SenderName,
                    Settings.UseDefaultCredentials));

                if (updated is not null)
                {
                    Settings = updated;
                }
            }

            StatusMessage = "Mail ayarları kaydedildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Mail ayarları kaydedilemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task ToggleAlarmAsync(MailAlarmDto? alarm)
    {
        if (IsBusy || alarm is null)
        {
            return;
        }

        try
        {
            IsBusy = true;
            var activeIds = Alarms.Where(a => a.IsActive).Select(a => a.Id).ToList();
            await _mailAlarmService.UpdateAsync(DefaultUserId, activeIds);
            StatusMessage = alarm.IsActive
                ? $"{alarm.Name} alarmı etkinleştirildi."
                : $"{alarm.Name} alarmı devre dışı bırakıldı.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Alarm güncellenemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
