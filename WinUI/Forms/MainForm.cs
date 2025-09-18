﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Helpers;
using WinUI.Pages;

namespace WinUI.Forms;

public partial class MainForm : Form
{
    private readonly HomePage _homePage;
    private readonly CalibrationPage _calibrationPage;
    private readonly SimulationPage _simulationPage;
    private readonly ReportingPage _reportingPage;
    private readonly MailPage _mailPage;
    private readonly SettingsPage _settingsPage;

    private Size _originalClientSize;
    private float _currentScaleFactor = 1f;
    private bool _isScaling;

    public MainForm(HomePage homePage, CalibrationPage calibrationPage, SimulationPage simulationPage, ReportingPage reportingPage, MailPage mailPage, SettingsPage settingsPage)
    {
        InitializeComponent();

        _homePage = homePage;
        _calibrationPage = calibrationPage;
        _simulationPage = simulationPage;
        _reportingPage = reportingPage;
        _mailPage = mailPage;
        _settingsPage = settingsPage;

        Resize += MainForm_Resize;
        PageManager.ShowPage(MainContentPanel, _homePage);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RoundedCorners.MakeRounded(HomePageButton, SimulationPageButton, CalibrationPageButton, MailPageButton, ReportingPageButton, SettingsPageButton);

        _originalClientSize = ClientSize;
        _currentScaleFactor = 1f;
        MainForm_Resize(this, EventArgs.Empty);
        Activate();
    }

    private void MainForm_Resize(object? sender, EventArgs e)
    {
        if (_isScaling || WindowState == FormWindowState.Minimized)
        {
            return;
        }

        if (_originalClientSize.Width == 0 || _originalClientSize.Height == 0)
        {
            return;
        }

        var widthRatio = (float)ClientSize.Width / _originalClientSize.Width;
        var heightRatio = (float)ClientSize.Height / _originalClientSize.Height;
        var targetScale = Math.Min(widthRatio, heightRatio);

        if (targetScale <= 0f)
        {
            return;
        }

        if (Math.Abs(targetScale - _currentScaleFactor) < 0.001f)
        {
            return;
        }

        var scaleFactor = targetScale / _currentScaleFactor;

        if (scaleFactor <= 0f)
        {
            return;
        }

        _isScaling = true;
        SuspendLayout();

        try
        {
            Scale(new SizeF(scaleFactor, scaleFactor));
        }
        finally
        {
            ResumeLayout();
            _isScaling = false;
        }

        PerformLayout();
        _currentScaleFactor = targetScale;
    }

    private void HomePageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, HomePageButton);
        PageManager.ShowPage(MainContentPanel, _homePage);
    }

    private void SimulationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SimulationPageButton);
        PageManager.ShowPage(MainContentPanel, _simulationPage);
    }

    private void CalibrationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, CalibrationPageButton);
        PageManager.ShowPage(MainContentPanel, _calibrationPage);
    }

    private void ReportingPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, ReportingPageButton);
        PageManager.ShowPage(MainContentPanel, _reportingPage);
    }

    private void SettingsPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SettingsPageButton);
        PageManager.ShowPage(MainContentPanel, new SettingsPage());
    }

    private void MailPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);
        PageManager.ShowPage(MainContentPanel, _mailPage);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();

        loginForm.ShowDialog();
    }
}
