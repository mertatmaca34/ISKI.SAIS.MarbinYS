using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinUI.Forms;

public partial class SplashScreenForm : Form
{
    private int _currentDotCount = 1;
    private const int MaxDots = 5;

    public SplashScreenForm()
    {
        var versionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);

        InitializeComponent();

        LabelVersion.Text = $"v{versionInfo.FileVersion}";

        timer1.Interval = 300; // hızını ayarlarsın
        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label3.Text = GenerateDots(_currentDotCount);
        _currentDotCount++;

        if (_currentDotCount > MaxDots)
            _currentDotCount = 1;
    }

    private string GenerateDots(int count)
    {
        return string.Join(" ", Enumerable.Repeat(".", count));
    }
}
