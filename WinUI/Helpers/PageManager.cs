using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Helpers;

public static class PageManager
{
    public static void ShowPage(Panel panel, UserControl page)
    {
        panel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        panel.Controls.Add(page);
    }
}
