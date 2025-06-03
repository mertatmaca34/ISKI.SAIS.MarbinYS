using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Helpers;

public static class RoundedCorners
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );

    public static void MakeRounded(params Control[] controls)
    {
        foreach (Control control in controls)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 10, 10));
        }
    }
}
