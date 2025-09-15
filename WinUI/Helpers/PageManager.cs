namespace WinUI.Helpers;

public static class PageManager
{
    public static void ShowPage(Panel panel, UserControl page)
    {
        panel.Controls.Clear();
        panel.Controls.Add(page);
        page.Show();
    }
}
