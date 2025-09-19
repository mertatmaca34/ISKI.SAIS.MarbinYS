using System;
using Microsoft.UI.Xaml.Controls;

namespace WinUI.Services.Navigation;

public interface INavigationService
{
    void Initialize(Frame frame);
    bool Navigate(Type pageType, object? parameter = null);
    bool CanGoBack { get; }
    void GoBack();
}

public sealed class NavigationService : INavigationService
{
    private Frame? _frame;

    public bool CanGoBack => _frame?.CanGoBack ?? false;

    public void Initialize(Frame frame)
    {
        _frame = frame ?? throw new ArgumentNullException(nameof(frame));
    }

    public bool Navigate(Type pageType, object? parameter = null)
    {
        if (_frame is null)
        {
            throw new InvalidOperationException("Navigation frame is not initialized.");
        }

        if (pageType is null)
        {
            throw new ArgumentNullException(nameof(pageType));
        }

        return _frame.Navigate(pageType, parameter);
    }

    public void GoBack()
    {
        if (_frame?.CanGoBack == true)
        {
            _frame.GoBack();
        }
    }
}
