using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WinUI.Forms;

public partial class SplashScreenForm : Form
{
    private int _currentDotCount = 1;
    private const int MaxDots = 5;
    private string _currentMessage = "Uygulama başlatılıyor";

    public SplashScreenForm()
    {
        var versionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);

        InitializeComponent();

        LabelVersion.Text = $"v{versionInfo.FileVersion}";

        UpdateLabelText();

        timer1.Interval = 300; // hızını ayarlarsın
        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        UpdateDots();
        UpdateLabelText();
    }

    private string GenerateDots(int count)
    {
        return string.Join(" ", Enumerable.Repeat(".", count));
    }

    private void UpdateDots()
    {
        _currentDotCount++;

        if (_currentDotCount > MaxDots)
            _currentDotCount = 1;
    }

    private void UpdateLabelText()
    {
        label3.Text = string.IsNullOrWhiteSpace(_currentMessage)
            ? GenerateDots(_currentDotCount)
            : $"{_currentMessage} {GenerateDots(_currentDotCount)}";
    }

    public void UpdateStatus(string message)
    {
        if (InvokeRequired)
        {
            Invoke(() => UpdateStatus(message));
            return;
        }

        _currentMessage = message;
        _currentDotCount = 1;
        UpdateLabelText();
    }
}
