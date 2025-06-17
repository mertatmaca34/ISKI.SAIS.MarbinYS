<<<<<<<<< Temporary merge branch 1
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

namespace WinUI.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        RoundedCorners.MakeRounded(HomePageButton, SimulationPageButton, CalibrationPageButton, MailPageButton, ReportingPageButton, SettingsPageButton);
    }

    private void HomePageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, HomePageButton);
    }

    private void SimulationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SimulationPageButton);
    }

    private void CalibrationPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, CalibrationPageButton);
    }

    private void MailPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, MailPageButton);
    }

    private void ReportingPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, ReportingPageButton);
    }

    private void SettingsPageButton_Click(object sender, EventArgs e)
    {
        ButtonImageExtensions.Replace(SideBarTableLayoutPanel, SettingsPageButton);
    }
}
