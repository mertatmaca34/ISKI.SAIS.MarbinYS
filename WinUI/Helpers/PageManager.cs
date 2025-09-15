using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Helpers;

public static class PageManager
{
    public static void ShowPage(Panel panel, UserControl page)
    {
        if (panel is null)
            throw new ArgumentNullException(nameof(panel));

        if (page is null)
            throw new ArgumentNullException(nameof(page));

        panel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        panel.Controls.Add(page);
    }
}
