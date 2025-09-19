using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using WinUI.Models;
using WinUI.ViewModels;

namespace WinUI.Views;

public sealed partial class MailPage : Page
{
    public MailPage()
    {
        InitializeComponent();
        ViewModel = App.GetService<MailViewModel>();
        DataContext = ViewModel;
    }

    public MailViewModel ViewModel { get; }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        ViewModel.LoadCommand.Execute(null);
    }

    private async void AlarmToggle_Toggled(object sender, RoutedEventArgs e)
    {
        if (sender is ToggleSwitch toggle && toggle.DataContext is MailAlarmDto alarm)
        {
            await ViewModel.ToggleAlarmCommand.ExecuteAsync(alarm);
        }
    }
}
