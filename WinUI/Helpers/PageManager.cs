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
        // Ensure the panel exists before attempting any operations on it
        if (panel is null)
            throw new ArgumentNullException(nameof(panel));

        // The page to be displayed must also be provided
        if (page is null)
            throw new ArgumentNullException(nameof(page));

        // Windows Forms controls can be disposed at runtime. Attempting to add a
        // disposed control to another container results in a NullReferenceException.
        // Guard against this scenario by throwing a more descriptive exception.
        if (page.IsDisposed)
            throw new ObjectDisposedException(page.GetType().Name);

        panel.SuspendLayout();

        panel.Controls.Clear();
        page.Dock = DockStyle.Fill;
        panel.Controls.Add(page);

        panel.ResumeLayout();
        page.BringToFront();
    }
}
