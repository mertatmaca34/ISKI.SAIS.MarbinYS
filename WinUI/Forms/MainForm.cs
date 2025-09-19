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

    public MainForm(HomePage homePage, CalibrationPage calibrationPage, SimulationPage simulationPage, ReportingPage reportingPage, MailPage mailPage, SettingsPage settingsPage)
    {
        InitializeComponent();

        _homePage = homePage;
        _calibrationPage = calibrationPage;
        _simulationPage = simulationPage;
        _reportingPage = reportingPage;
        _mailPage = mailPage;
        _settingsPage = settingsPage;

        PageManager.ShowPage(MainContentPanel, _homePage, this);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RoundedCorners.MakeRounded(HomePageButton, SimulationPageButton, CalibrationPageButton, MailPageButton, ReportingPageButton, SettingsPageButton);

        Activate();
    }

    private void HomePageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, HomePageButton);
        PageManager.ShowPage(MainContentPanel, _homePage, this);
    }

    private void SimulationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SimulationPageButton);
        PageManager.ShowPage(MainContentPanel, _simulationPage, this);
    }

    private void CalibrationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, CalibrationPageButton);
        PageManager.ShowPage(MainContentPanel, _calibrationPage, this);
    }

    private void ReportingPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, ReportingPageButton);
        PageManager.ShowPage(MainContentPanel, _reportingPage, this);
    }

    private void SettingsPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SettingsPageButton);
        PageManager.ShowPage(MainContentPanel, new SettingsPage(), this);
    }

    private void MailPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);
        PageManager.ShowPage(MainContentPanel, _mailPage, this);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();

        loginForm.ShowDialog();
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        foreach (UserControl activeForm in MainContentPanel.Controls)
        {
            activeForm.Size = MainContentPanel.Size;
        }
    }
}
