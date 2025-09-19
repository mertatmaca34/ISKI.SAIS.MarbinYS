﻿using System;
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
    public partial class StatusBarControl: UserControl
    {
        [Description("Bağlantı Durumu"), Category("IBKS")]
        public string ConnectionStatement
        {
            get => LabelBaglantiDurumu.Text;
            set => LabelBaglantiDurumu.Text = value;
        }

        [Description("Bağlantı Zamanı"), Category("IBKS")]
        public string ConnectionTime
        {
            get => LabelBaglantiZamani.Text;
            set => LabelBaglantiZamani.Text = value;
        }

        [Description("Günlük Yıkamaya Kalan Süre"), Category("IBKS")]
        public string GunlukYikamaKalan
        {
            get => LabelGYikamayaKalan.Text;
            set => LabelGYikamayaKalan.Text = value;
        }

        [Description("Haftalık Yıkamaya Kalan Süre"), Category("IBKS")]
        public string HaftalikYikamaKalan
        {
            get => LabelHYikamaKalan.Text;
            set => LabelHYikamaKalan.Text = value;
        }

        [Description("Sistem Saati"), Category("IBKS")]
        public string SistemSaati
        {
            get => LabelSistemSaati.Text;
            set => LabelSistemSaati.Text = value;
        }

        public StatusBarControl()
        {
            InitializeComponent();
        }
    }
}
