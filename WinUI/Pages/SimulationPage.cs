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
using WinUI.Models;

namespace WinUI.Pages
{
    public partial class SimulationPage : UserControl
    {
        private readonly IPlcDataService _plcService;

        private bool _pump1Running;
        private bool _pump2Running;

        private readonly Bitmap _autoFrame;
        private readonly Bitmap _autoFrame2;
        private readonly Bitmap _doorClosed;
        private readonly Bitmap _doorOpened;
        private readonly Bitmap _pump1Idle;
        private readonly Bitmap _pump2Idle;
        private readonly Bitmap _pump1Animation;
        private readonly Bitmap _pump2Animation;
        private readonly Bitmap _waterTankEmpty;
        private readonly Bitmap _waterTankFull;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParms = base.CreateParams;
                handleParms.ExStyle |= 0x02000000;
                return handleParms;
            }
        }

        public SimulationPage(IPlcDataService plcService)
        {
            InitializeComponent();
            _plcService = plcService;

            _autoFrame = Properties.Resources.system_auto1;
            _autoFrame2 = Properties.Resources.system_auto2;

            _doorClosed = Properties.Resources.door_closed;
            _doorOpened = Properties.Resources.door_opened;

            _pump1Animation = Properties.Resources.pump1_animation;
            _pump2Animation = Properties.Resources.pump2_animation;
            _pump1Idle = Properties.Resources.pump1_idle;
            _pump2Idle = Properties.Resources.pump2_idle;

            _waterTankEmpty = Properties.Resources.water_tank_empty;
            _waterTankFull = Properties.Resources.water_tank_full;

            BackgroundImage = _autoFrame;
            PanelDoor.BackgroundImage = _doorClosed;
            PictureBoxPump1.Image = _pump1Idle;
            PictureBoxPump2.Image = _pump2Idle;
            PanelWaterTank.BackgroundImage = _waterTankEmpty;
        }

        private void AssignLabelValues(PlcDataDto value)
        {
            LabelAkm.Text = value.Analog.Akm.ToString();
            LabelPh.Text = value.Analog.Ph.ToString();
            LabelKoi.Text = value.Analog.Koi.ToString();
            LabelIletkenlik.Text = value.Analog.Iletkenlik.ToString();
            LabelOksijen.Text = value.Analog.CozunmusOksijen.ToString();
            LabelAkisHizi.Text = value.Analog.AkisHizi.ToString();
            LabelSicaklik.Text = value.Analog.Sicaklik.ToString();
            LabelDebi.Text = value.Analog.Debi.ToString();
            LabelDesarjDebi.Text = value.Analog.DesarjDebi?.ToString() ?? "0";
            LabelHariciDebi.Text = value.Analog.HariciDebi?.ToString() ?? "0";
            LabelHariciDebi2.Text = value.Analog.HariciDebi2?.ToString() ?? "0";
        }

        private void Animate(PlcDataDto value)
        {
            PanelDoor.BackgroundImage = value.Digital.KabinKapiAcildi ? _doorOpened : _doorClosed;
            PanelWaterTank.BackgroundImage = value.Digital.TankDolu ? _waterTankFull : _waterTankEmpty;

            var pump1Running = value.Digital.Pompa1Calisiyor;
            if (pump1Running != _pump1Running)
            {
                PictureBoxPump1.Image = pump1Running ? _pump1Animation : _pump1Idle;
                _pump1Running = pump1Running;
            }

            var pump2Running = value.Digital.Pompa2Calisiyor;
            if (pump2Running != _pump2Running)
            {
                PictureBoxPump2.Image = pump2Running ? _pump2Animation : _pump2Idle;
                _pump2Running = pump2Running;
            }
        }

        private void SimulationPage_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
