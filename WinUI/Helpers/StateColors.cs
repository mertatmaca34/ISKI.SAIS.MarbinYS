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
    /// Color used when an error occurs while retrieving PLC data.
    /// </summary>
    public static readonly Color Error = Color.FromArgb(235, 85, 101);

    /// <summary>
    /// Color used when PLC configuration is missing either in the database or settings.
    /// </summary>
    public static readonly Color NotConfigured = Color.FromArgb(204, 153, 0);

    /// <summary>
    /// Color used when PLC is configured but cannot be reached.
    /// </summary>
    public static readonly Color NoAccess = Color.FromArgb(220, 53, 69);
}
