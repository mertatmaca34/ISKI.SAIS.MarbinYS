using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using WinUI.Services.Navigation;
using WinUI.Views;

namespace WinUI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    public MainViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;

        NavigationItems = new ObservableCollection<NavigationItemViewModel>
        {
            new("home", "Ana Sayfa", Symbol.Home, typeof(HomePage)),
            new("calibration", "Kalibrasyon", Symbol.Calculator, typeof(CalibrationPage)),
            new("simulation", "Simülasyon", Symbol.Play, typeof(SimulationPage)),
            new("reporting", "Raporlama", Symbol.Document, typeof(ReportingPage)),
            new("mail", "E-Posta", Symbol.Mail, typeof(MailPage)),
            new("settings", "Ayarlar", Symbol.Setting, typeof(SettingsPage))
        };

        NavigateCommand = new RelayCommand<NavigationItemViewModel>(OnNavigate, CanNavigate);
    }

    public ObservableCollection<NavigationItemViewModel> NavigationItems { get; }

    public IRelayCommand<NavigationItemViewModel> NavigateCommand { get; }

    [ObservableProperty]
    private NavigationItemViewModel? selectedItem;

    private bool CanNavigate(NavigationItemViewModel? item)
    {
        return item is not null;
    }

    private void OnNavigate(NavigationItemViewModel? item)
    {
        if (item is null)
        {
            return;
        }

        if (_navigationService.Navigate(item.PageType))
        {
            SelectedItem = item;
        }
    }
}
