using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Controls.IBKS
{
    public partial class DigitalSensorControl: UserControl
    {
        [Description("Kanal adı"), Category("IBKS")]
        public string SensorName
        {
            get => LabelSensorName.Text;
            set => LabelSensorName.Text = value;
        }

        [Description("Kanal Açıklaması"), Category("IBKS")]
        public string SensorDescription
        {
            get => LabelSensorDescription.Text;
            set => LabelSensorDescription.Text = value;
        }

        [Description("Kanal Durumu"), Category("IBKS")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color SensorState
        {
            get => PanelSensorState.BackColor;
            set => PanelSensorState.BackColor = value;
        }
        public DigitalSensorControl()
        {
            InitializeComponent();
        }
    }
}
