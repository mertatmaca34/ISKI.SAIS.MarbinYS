using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using WinUI.ViewModels;

namespace WinUI.Views;

public sealed partial class CalibrationPage : Page
{
    public CalibrationPage()
    {
        InitializeComponent();
        ViewModel = App.GetService<CalibrationViewModel>();
        DataContext = ViewModel;
    }

    public CalibrationViewModel ViewModel { get; }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        ViewModel.LoadLimitsCommand.Execute(null);
    }
}
