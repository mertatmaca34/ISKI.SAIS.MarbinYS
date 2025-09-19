using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinUI.Properties;

namespace WinUI.Helpers;

public static class ButtonImageExtensions
{
    private static readonly Dictionary<string, (Bitmap normal, Bitmap filled)> _buttonImages = new()
    {
        ["HomePageButton"] = (Resources.home_24px, Resources.filled_home_24px),
        ["SimulationPageButton"] = (Resources.monitor_24px, Resources.filled_monitor_24px),
        ["CalibrationPageButton"] = (Resources.azimuth_24px, Resources.filled_azimuth_24px),
        ["MailPageButton"] = (Resources.alarm_24px, Resources.filled_alarm_24px),
        ["ReportingPageButton"] = (Resources.save_24px, Resources.filled_save_24px),
        ["SettingsPageButton"] = (Resources.settings_24px, Resources.filled_settings_24px)
    };

    private static readonly Color NormalColor = Color.White;
    private static readonly Color SelectedColor = Color.FromArgb(230, 230, 230);

    public static void Replace(TableLayoutPanel tableLayoutPanel, Button selectedButton)
    {
        foreach (Control control in tableLayoutPanel.Controls)
        {
            if (control is not Button button)
                continue;

            if (!_buttonImages.TryGetValue(button.Name, out var images))
                continue;

            bool isSelected = button == selectedButton;
            button.Image = isSelected ? images.filled : images.normal;
            button.BackColor = isSelected ? SelectedColor : NormalColor;
        }
    }
}
