using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class MailSettingsPage : UserControl
{
    private readonly IMailSettingsService _mailSettingsService;

    public MailSettingsPage()
    {
        InitializeComponent();
        _mailSettingsService = Program.Services.GetRequiredService<IMailSettingsService>();
        Load += MailSettingsPage_Load;
        SaveMailSettingsButton.Click += SaveMailSettingsButton_Click;
        TestConnectionButton.Click += TestConnectionButton_Click;
        SendTestEmailButton.Click += SendTestEmailButton_Click;
    }

    private async void MailSettingsPage_Load(object? sender, EventArgs e)
    {
        var settings = await _mailSettingsService.GetFirstAsync();
        if (settings != null)
        {
            PopulateSettings(settings);
        }
    }

    private void PopulateSettings(MailSettingsDto dto)
    {
        SmtpHostTextBox.Text = dto.SmtpHost;
        SmtpPortTextBox.Text = dto.SmtpPort.ToString();
        SmtpUserTextBox.Text = dto.SmtpUser;
        SmtpPasswordTextBox.Text = dto.SmtpPassword;
        UseSslCheckBox.Checked = dto.UseSsl;
        SenderEmailTextBox.Text = dto.SenderEmail;
        SenderNameTextBox.Text = dto.SenderName;
        UseDefaultCredentialsCheckBox.Checked = dto.UseDefaultCredentials;
    }

    private async void SaveMailSettingsButton_Click(object? sender, EventArgs e)
    {
        int port = int.TryParse(SmtpPortTextBox.Text, out var p) ? p : 0;
        var existing = await _mailSettingsService.GetFirstAsync();
        MailSettingsDto? result;
        if (existing == null)
        {
            var command = new CreateMailSettingsCommand(
                SmtpHostTextBox.Text,
                port,
                SmtpUserTextBox.Text,
                SmtpPasswordTextBox.Text,
                UseSslCheckBox.Checked,
                SenderEmailTextBox.Text,
                SenderNameTextBox.Text,
                UseDefaultCredentialsCheckBox.Checked);
            result = await _mailSettingsService.CreateAsync(command);
        }
        else
        {
            var command = new UpdateMailSettingsCommand(
                existing.Id,
                SmtpHostTextBox.Text,
                port,
                SmtpUserTextBox.Text,
                SmtpPasswordTextBox.Text,
                UseSslCheckBox.Checked,
                SenderEmailTextBox.Text,
                SenderNameTextBox.Text,
                UseDefaultCredentialsCheckBox.Checked);
            result = await _mailSettingsService.UpdateAsync(command);
        }

        if (result != null)
        {
            MessageBox.Show(MailSettingsConstants.SettingsSavedMessage, MailSettingsConstants.InfoTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async void TestConnectionButton_Click(object? sender, EventArgs e)
    {
        await SendMailAsync(SenderEmailTextBox.Text);
    }

    private async void SendTestEmailButton_Click(object? sender, EventArgs e)
    {
        await SendMailAsync(TestEmailTextBox.Text);
    }

    private async Task SendMailAsync(string to)
    {
        try
        {
            using var client = new SmtpClient(SmtpHostTextBox.Text, int.Parse(SmtpPortTextBox.Text))
            {
                EnableSsl = UseSslCheckBox.Checked,
                UseDefaultCredentials = UseDefaultCredentialsCheckBox.Checked,
                Credentials = new NetworkCredential(SmtpUserTextBox.Text, SmtpPasswordTextBox.Text)
            };
            var message = new MailMessage(SenderEmailTextBox.Text, to, "Test", "Test");
            await client.SendMailAsync(message);
            ResponseTextBox.Text = "İşlem başarılı.";
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = ex.Message;
        }
    }
}

