﻿﻿using System;
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
using WinUI.Pages.Mail;

namespace WinUI.Forms;

public partial class MainForm : Form
{
    HomePage _homePage;
    CalibrationPage _calibrationPage;
    SimulationPage _simulationPage;
    ReportingPage _reportingPage;
    MailPage _mailPage;

    public MainForm(HomePage homePage, CalibrationPage calibrationPage, SimulationPage simulationPage, ReportingPage reportingPage, MailPage mailPage)
    {
        InitializeComponent();

        _homePage = homePage;
        _calibrationPage = calibrationPage;
        _simulationPage = simulationPage;
        _reportingPage = reportingPage;
        _mailPage = mailPage;

        PageManager.ShowPage(MainContentPanel, _homePage);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RoundedCorners.MakeRounded(HomePageButton, SimulationPageButton, CalibrationPageButton, MailPageButton, ReportingPageButton, SettingsPageButton);

        Activate();
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

    private void MailPageButton_MouseClick(object sender, MouseEventArgs e)
    {
        MailPageButton.ContextMenuStrip!.Show(MailPageButton, new Point(e.X, e.Y));
    }

    private void ReportingPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, ReportingPageButton);
        PageManager.ShowPage(MainContentPanel, _reportingPage);
    }

    private void SettingsPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SettingsPageButton);
    }

    private void EventTriggersButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);

        PageManager.ShowPage(MainContentPanel, new EventTriggersPage());
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();

        loginForm.ShowDialog();
    }

    private void MailUsersButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);

        PageManager.ShowPage(MainContentPanel, new MailUsersPage());
    }

    private void MailSettingsButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);

        PageManager.ShowPage(MainContentPanel, new MailSettingsPage());
    }
}
