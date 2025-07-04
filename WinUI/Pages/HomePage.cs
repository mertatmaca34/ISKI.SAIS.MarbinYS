using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class HomePage : UserControl
    {
        private readonly IPlcDataService _plcService;

        public HomePage(IPlcDataService plcService)
        {
            InitializeComponent();
            _plcService = plcService;
        }

        public Task<PlcDataDto?> ReadPlcDataAsync()
        {
            return _plcService.ReadAndSaveAsync();
        }
    }
}
