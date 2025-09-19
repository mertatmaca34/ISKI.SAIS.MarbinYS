using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WinUI.Services.Navigation;
using WinUI.ViewModels;

namespace WinUI;

public sealed partial class MainWindow : Window
{
    private readonly INavigationService _navigationService;
    private bool _isInitializing;

    public MainWindow(MainViewModel viewModel, INavigationService navigationService)
    {
        InitializeComponent();
        ViewModel = viewModel;
        _navigationService = navigationService;
        DataContext = this;

        Loaded += OnLoaded;
        ShellNavigationView.SelectionChanged += OnSelectionChanged;
        ShellNavigationView.BackRequested += OnBackRequested;
    }

    public MainViewModel ViewModel { get; }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        _navigationService.Initialize(ContentFrame);
        if (ViewModel.NavigationItems.Count > 0)
        {
            var defaultItem = ViewModel.NavigationItems[0];
            _isInitializing = true;
            ShellNavigationView.SelectedItem = defaultItem;
            _isInitializing = false;
            ViewModel.NavigateCommand.Execute(defaultItem);
        }
    }

    private void OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (_isInitializing)
        {
            return;
        }

        if (args.SelectedItem is NavigationItemViewModel navigationItem)
        {
            ViewModel.NavigateCommand.Execute(navigationItem);
        }
    }

    private void OnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
    {
        if (_navigationService.CanGoBack)
        {
            _navigationService.GoBack();
        }
    }
}
