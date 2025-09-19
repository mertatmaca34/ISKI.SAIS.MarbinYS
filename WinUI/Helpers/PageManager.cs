using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Windows.Forms;
using WinUI.Forms;

namespace WinUI.Helpers;

public static class PageManager
{
    public static void ShowPage(Panel panel, UserControl page, MainForm mainForm = null)
    {
        if (panel is null)
        {
            throw new ArgumentNullException(nameof(panel));
        }

        if (page is null)
        {
            throw new ArgumentNullException(nameof(page));
        }

        if (page.Parent is Panel currentParent && currentParent != panel)
        {
            currentParent.Controls.Remove(page);
        }

        for (int i = panel.Controls.Count - 1; i >= 0; i--)
        {
            var control = panel.Controls[i];
            if (!ReferenceEquals(control, page))
            {
                panel.Controls.RemoveAt(i);
            }
        }

        if (!panel.Controls.Contains(page))
        {
            panel.Controls.Add(page);
        }

        page.Show();
        page.BringToFront();

        foreach (UserControl activeForm in panel.Controls)
        {
            activeForm.Size = panel.Size;
        }

        if (page.Name == "SimulationPage" && mainForm != null)
        {
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.MaximumSize = new Size(1280, 720);

            mainForm.MaximizeBox = false;
        }
        else if (mainForm != null)
        {
            mainForm.MaximumSize = new Size(0, 0);

            mainForm.MaximizeBox = true;
        }
    }
}
