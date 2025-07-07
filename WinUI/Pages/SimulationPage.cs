using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class SimulationPage : UserControl
    {
        private readonly IPlcDataService _plcService;

        private bool _pump1Frame;
        private bool _pump2Frame;

        public SimulationPage(IPlcDataService plcService)
        {
            InitializeComponent();
            _plcService = plcService;
        }
    }
}
