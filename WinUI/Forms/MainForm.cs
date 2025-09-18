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
    HomePage _homePage;
    CalibrationPage _calibrationPage;
    SimulationPage _simulationPage;
    ReportingPage _reportingPage;
    MailPage _mailPage;
    SettingsPage _settingsPage;
    private readonly Size _baseClientSize;

    public MainForm(HomePage homePage, CalibrationPage calibrationPage, SimulationPage simulationPage, ReportingPage reportingPage, MailPage mailPage, SettingsPage settingsPage)
    {
        InitializeComponent();

        _homePage = homePage;
        _calibrationPage = calibrationPage;
        _simulationPage = simulationPage;
        _reportingPage = reportingPage;
        _mailPage = mailPage;
        _settingsPage = settingsPage;

        _baseClientSize = ClientSize;
        ControlScalingHelper.CaptureBaseMetrics(this);
        PageManager.ShowPage(MainContentPanel, _homePage);
        ApplyScaling();
        Resize += MainForm_Resize;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RoundedCorners.MakeRounded(HomePageButton, SimulationPageButton, CalibrationPageButton, MailPageButton, ReportingPageButton, SettingsPageButton);

        ApplyScaling();
        Activate();
    }

    private void MainForm_Resize(object? sender, EventArgs e)
    {
        ApplyScaling();
    }

    private void ApplyScaling()
    {
        var scaleFactor = ControlScalingHelper.CalculateScaleFactor(_baseClientSize, ClientSize);
        ControlScalingHelper.ScaleFonts(this, scaleFactor);
    }

    private void HomePageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, HomePageButton);
        PageManager.ShowPage(MainContentPanel, _homePage);
        ApplyScaling();
    }

    private void SimulationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SimulationPageButton);
        PageManager.ShowPage(MainContentPanel, _simulationPage);
        ApplyScaling();
    }

    private void CalibrationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, CalibrationPageButton);
        PageManager.ShowPage(MainContentPanel, _calibrationPage);
        ApplyScaling();
    }

    private void ReportingPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, ReportingPageButton);
        PageManager.ShowPage(MainContentPanel, _reportingPage);
        ApplyScaling();
    }

    private void SettingsPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SettingsPageButton);
        PageManager.ShowPage(MainContentPanel, new SettingsPage());
        ApplyScaling();
    }

    private void MailPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);
        PageManager.ShowPage(MainContentPanel, _mailPage);
        ApplyScaling();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();

        loginForm.ShowDialog();
    }
}
