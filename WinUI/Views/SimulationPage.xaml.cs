using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using WinUI.ViewModels;

namespace WinUI.Views;

public sealed partial class SimulationPage : Page
{
    public SimulationPage()
    {
        InitializeComponent();
        ViewModel = App.GetService<SimulationViewModel>();
        DataContext = ViewModel;
    }

    public SimulationViewModel ViewModel { get; }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        ViewModel.LoadDataCommand.Execute(null);
    }
}
