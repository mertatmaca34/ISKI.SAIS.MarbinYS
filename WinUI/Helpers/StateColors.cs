using System.Drawing;

namespace WinUI.Helpers;

/// <summary>
/// Central definition of colors used for PLC and sensor states.
/// </summary>
public static class StateColors
{
    /// <summary>
    /// Color used when status is unknown or data has not been retrieved yet.
    /// </summary>
    public static readonly Color Waiting = Color.Black;

    /// <summary>
    /// Color used when the PLC connection and data are healthy.
    /// </summary>
    public static readonly Color Ok = Color.FromArgb(19, 162, 97);

    /// <summary>
    /// Color used when a configuration is missing or attention is required.
    /// </summary>
    public static readonly Color Warning = Color.FromArgb(204, 153, 0);

    /// <summary>
    /// Color used when an error occurs while retrieving PLC data.
    /// </summary>
    public static readonly Color Error = Color.FromArgb(235, 85, 101);
}
