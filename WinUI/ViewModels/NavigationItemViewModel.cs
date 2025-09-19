using Microsoft.UI.Xaml.Controls;

namespace WinUI.ViewModels;

public sealed class NavigationItemViewModel
{
    public NavigationItemViewModel(string key, string title, Symbol icon, Type pageType)
    {
        Key = key;
        Title = title;
        Icon = icon;
        PageType = pageType;
    }

    public string Key { get; }

    public string Title { get; }

    public Symbol Icon { get; }

    public Type PageType { get; }
}
