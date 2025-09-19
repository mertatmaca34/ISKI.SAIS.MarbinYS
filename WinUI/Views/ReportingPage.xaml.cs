using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using WinUI.ViewModels;

namespace WinUI.Views;

public sealed partial class ReportingPage : Page
{
    public ReportingPage()
    {
        InitializeComponent();
        ViewModel = App.GetService<ReportingViewModel>();
        DataContext = ViewModel;
    }

    public ReportingViewModel ViewModel { get; }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        ViewModel.LoadReportsCommand.Execute(null);
    }
}
