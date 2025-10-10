﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Helpers;
using WinUI.StationSetup.Pages;

namespace WinUI.Forms
{
    public partial class StationSetupForm : Form
    {
        public StationSetupForm()
        {
            InitializeComponent();
        }

        private void StationSetupForm_Load(object sender, EventArgs e)
        {
            PageManager.ShowPage(panel1, new ApiSetupPage());
        }
    }
}
