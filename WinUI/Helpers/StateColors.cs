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
    public static readonly Color Waiting = Color.Gray;

    /// <summary>
    /// Color used when the PLC connection and data are healthy.
    /// </summary>
    public static readonly Color Ok = Color.LimeGreen;

    /// <summary>
    /// Color used when an error occurs while retrieving PLC data.
    /// </summary>
    public static readonly Color Error = Color.Red;
}
