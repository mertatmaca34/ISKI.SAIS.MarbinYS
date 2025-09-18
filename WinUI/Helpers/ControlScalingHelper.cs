using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WinUI.Helpers;

public static class ControlScalingHelper
{
    private const string StandardFontFamily = "Segoe UI";
    private static readonly ConditionalWeakTable<Control, Font> BaseFonts = new();

    public static void CaptureBaseMetrics(Control control)
    {
        if (control == null)
        {
            return;
        }

        if (!BaseFonts.TryGetValue(control, out _))
        {
            var font = control.Font;
            if (!string.Equals(font.FontFamily.Name, StandardFontFamily, StringComparison.OrdinalIgnoreCase))
            {
                font = new Font(StandardFontFamily, font.Size, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
                control.Font = font;
            }
            BaseFonts.Add(control, new Font(font.FontFamily, font.Size, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont));
        }

        foreach (Control child in control.Controls)
        {
            CaptureBaseMetrics(child);
        }
    }

    public static void ScaleFonts(Control control, float scaleFactor, float minimumSize = 6f)
    {
        if (control == null)
        {
            return;
        }

        if (BaseFonts.TryGetValue(control, out var baseFont))
        {
            var targetSize = Math.Max(baseFont.Size * scaleFactor, minimumSize);
            if (Math.Abs(control.Font.Size - targetSize) > 0.1f ||
                control.Font.FontFamily.Name != baseFont.FontFamily.Name ||
                control.Font.Style != baseFont.Style)
            {
                control.Font = new Font(baseFont.FontFamily, targetSize, baseFont.Style, baseFont.Unit, baseFont.GdiCharSet, baseFont.GdiVerticalFont);
            }
        }

        foreach (Control child in control.Controls)
        {
            ScaleFonts(child, scaleFactor, minimumSize);
        }
    }

    public static float CalculateScaleFactor(Size originalSize, Size currentSize)
    {
        if (originalSize.Width == 0 || originalSize.Height == 0)
        {
            return 1f;
        }

        var widthScale = (float)currentSize.Width / originalSize.Width;
        var heightScale = (float)currentSize.Height / originalSize.Height;

        return Math.Min(widthScale, heightScale);
    }
}
