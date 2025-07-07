using WinUI.Helpers;

namespace WinUI.Pages
{
    partial class HomePage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ChannelDebi = new WinUI.Controls.IBKS.ChannelControl();
            ChannelAkisHizi = new WinUI.Controls.IBKS.ChannelControl();
            ChannelKoi = new WinUI.Controls.IBKS.ChannelControl();
            ChannelIletkenlik = new WinUI.Controls.IBKS.ChannelControl();
            ChannelPh = new WinUI.Controls.IBKS.ChannelControl();
            ChannelSicaklik = new WinUI.Controls.IBKS.ChannelControl();
            ChannelCozunmusOksijen = new WinUI.Controls.IBKS.ChannelControl();
            channelControl1 = new WinUI.Controls.IBKS.ChannelControl();
            ChannelAkm = new WinUI.Controls.IBKS.ChannelControl();
            tableLayoutPanel3 = new TableLayoutPanel();
            DigitalSensorKapi = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorDuman = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorSuBaskini = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorPompa2Termik = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorPompa1Termik = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorAcilStop = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorTSuPompaTermik = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorYikamaTanki = new WinUI.Controls.IBKS.DigitalSensorControl();
            DigitalSensorEnerji = new WinUI.Controls.IBKS.DigitalSensorControl();
            digitalSensorBar1 = new WinUI.Controls.IBKS.DigitalSensorBar();
            StationInfoControl = new WinUI.Controls.IBKS.StationInfoControl();
            StatusBarControl = new WinUI.Controls.IBKS.StatusBarControl();
            TimerAssignUI = new System.Windows.Forms.Timer(components);
            TimerGetMissingDates = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(StationInfoControl, 1, 1);
            tableLayoutPanel1.Controls.Add(StatusBarControl, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ChannelDebi, 0, 8);
            tableLayoutPanel2.Controls.Add(ChannelAkisHizi, 0, 7);
            tableLayoutPanel2.Controls.Add(ChannelKoi, 0, 6);
            tableLayoutPanel2.Controls.Add(ChannelIletkenlik, 0, 5);
            tableLayoutPanel2.Controls.Add(ChannelPh, 0, 4);
            tableLayoutPanel2.Controls.Add(ChannelSicaklik, 0, 3);
            tableLayoutPanel2.Controls.Add(ChannelCozunmusOksijen, 0, 2);
            tableLayoutPanel2.Controls.Add(channelControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(ChannelAkm, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(574, 625);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ChannelDebi
            // 
            ChannelDebi.AvgDataOf60Min = "-";
            ChannelDebi.BackColor = Color.FromArgb(230, 230, 230);
            ChannelDebi.ChannelDescription = "Tesis Debisi";
            ChannelDebi.ChannelName = "Debi";
            ChannelDebi.Dock = DockStyle.Fill;
            ChannelDebi.InstantData = "-";
            ChannelDebi.Location = new Point(3, 555);
            ChannelDebi.Name = "ChannelDebi";
            ChannelDebi.Size = new Size(568, 67);
            ChannelDebi.TabIndex = 8;
            // 
            // ChannelAkisHizi
            // 
            ChannelAkisHizi.AvgDataOf60Min = "-";
            ChannelAkisHizi.BackColor = Color.FromArgb(230, 230, 230);
            ChannelAkisHizi.ChannelDescription = "Tank dolum boşaltım hızı";
            ChannelAkisHizi.ChannelName = "Akış Hızı";
            ChannelAkisHizi.Dock = DockStyle.Fill;
            ChannelAkisHizi.InstantData = "-";
            ChannelAkisHizi.Location = new Point(3, 486);
            ChannelAkisHizi.Name = "ChannelAkisHizi";
            ChannelAkisHizi.Size = new Size(568, 63);
            ChannelAkisHizi.TabIndex = 7;
            // 
            // ChannelKoi
            // 
            ChannelKoi.AvgDataOf60Min = "-";
            ChannelKoi.BackColor = Color.FromArgb(230, 230, 230);
            ChannelKoi.ChannelDescription = "Kimyasal Oksijen İhtiyacı";
            ChannelKoi.ChannelName = "KOi";
            ChannelKoi.Dock = DockStyle.Fill;
            ChannelKoi.InstantData = "-";
            ChannelKoi.Location = new Point(3, 417);
            ChannelKoi.Name = "ChannelKoi";
            ChannelKoi.Size = new Size(568, 63);
            ChannelKoi.TabIndex = 6;
            // 
            // ChannelIletkenlik
            // 
            ChannelIletkenlik.AvgDataOf60Min = "-";
            ChannelIletkenlik.BackColor = Color.FromArgb(230, 230, 230);
            ChannelIletkenlik.ChannelDescription = "Sudaki İletkenlik seviyesi";
            ChannelIletkenlik.ChannelName = "İletkenlik";
            ChannelIletkenlik.Dock = DockStyle.Fill;
            ChannelIletkenlik.InstantData = "-";
            ChannelIletkenlik.Location = new Point(3, 348);
            ChannelIletkenlik.Name = "ChannelIletkenlik";
            ChannelIletkenlik.Size = new Size(568, 63);
            ChannelIletkenlik.TabIndex = 5;
            // 
            // ChannelPh
            // 
            ChannelPh.AvgDataOf60Min = "-";
            ChannelPh.BackColor = Color.FromArgb(230, 230, 230);
            ChannelPh.ChannelDescription = "Potansiyel Hidrojen";
            ChannelPh.ChannelName = "pH";
            ChannelPh.Dock = DockStyle.Fill;
            ChannelPh.InstantData = "-";
            ChannelPh.Location = new Point(3, 279);
            ChannelPh.Name = "ChannelPh";
            ChannelPh.Size = new Size(568, 63);
            ChannelPh.TabIndex = 4;
            // 
            // ChannelSicaklik
            // 
            ChannelSicaklik.AvgDataOf60Min = "-";
            ChannelSicaklik.BackColor = Color.FromArgb(230, 230, 230);
            ChannelSicaklik.ChannelDescription = "Kabin içi sıcaklığı";
            ChannelSicaklik.ChannelName = "Sıcaklık";
            ChannelSicaklik.Dock = DockStyle.Fill;
            ChannelSicaklik.InstantData = "-";
            ChannelSicaklik.Location = new Point(3, 210);
            ChannelSicaklik.Name = "ChannelSicaklik";
            ChannelSicaklik.Size = new Size(568, 63);
            ChannelSicaklik.TabIndex = 3;
            // 
            // ChannelCozunmusOksijen
            // 
            ChannelCozunmusOksijen.AvgDataOf60Min = "-";
            ChannelCozunmusOksijen.BackColor = Color.FromArgb(230, 230, 230);
            ChannelCozunmusOksijen.ChannelDescription = "Suda bulunan gaz Oksijen miktarı";
            ChannelCozunmusOksijen.ChannelName = "Çözünmüş Oksijen";
            ChannelCozunmusOksijen.Dock = DockStyle.Fill;
            ChannelCozunmusOksijen.InstantData = "-";
            ChannelCozunmusOksijen.Location = new Point(3, 141);
            ChannelCozunmusOksijen.Name = "ChannelCozunmusOksijen";
            ChannelCozunmusOksijen.Size = new Size(568, 63);
            ChannelCozunmusOksijen.TabIndex = 2;
            // 
            // channelControl1
            // 
            channelControl1.AvgDataOf60Min = "SAATLİK ORTALAMA";
            channelControl1.BackColor = Color.FromArgb(230, 230, 230);
            channelControl1.ChannelDescription = "SENSÖR İSİMLERİ";
            channelControl1.ChannelName = "ANALOG SENSÖRLER";
            channelControl1.ChannelStatement = Color.FromArgb(0, 131, 200);
            channelControl1.Dock = DockStyle.Fill;
            channelControl1.InstantData = "ANLIK VERİ";
            channelControl1.Location = new Point(3, 3);
            channelControl1.Name = "channelControl1";
            channelControl1.PanelSplit1Visible = false;
            channelControl1.PanelSplit2Visible = false;
            channelControl1.Size = new Size(568, 63);
            channelControl1.TabIndex = 0;
            // 
            // ChannelAkm
            // 
            ChannelAkm.AvgDataOf60Min = "-";
            ChannelAkm.BackColor = Color.FromArgb(230, 230, 230);
            ChannelAkm.ChannelDescription = "Askıda Katı Madde";
            ChannelAkm.ChannelName = "AKM";
            ChannelAkm.Dock = DockStyle.Fill;
            ChannelAkm.InstantData = "-";
            ChannelAkm.Location = new Point(3, 72);
            ChannelAkm.Name = "ChannelAkm";
            ChannelAkm.Size = new Size(568, 63);
            ChannelAkm.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(DigitalSensorKapi, 0, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorDuman, 1, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorSuBaskini, 2, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa2Termik, 2, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa1Termik, 1, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorAcilStop, 0, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorTSuPompaTermik, 0, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorYikamaTanki, 1, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorEnerji, 2, 3);
            tableLayoutPanel3.Controls.Add(digitalSensorBar1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(588, 12);
            tableLayoutPanel3.Margin = new Padding(3, 7, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(574, 200);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // DigitalSensorKapi
            // 
            DigitalSensorKapi.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorKapi.Dock = DockStyle.Fill;
            DigitalSensorKapi.Location = new Point(0, 50);
            DigitalSensorKapi.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorKapi.Name = "DigitalSensorKapi";
            DigitalSensorKapi.Padding = new Padding(1);
            DigitalSensorKapi.SensorDescription = "Kabin Kapısı";
            DigitalSensorKapi.SensorName = "Kapı";
            DigitalSensorKapi.Size = new Size(188, 50);
            DigitalSensorKapi.TabIndex = 1;
            // 
            // DigitalSensorDuman
            // 
            DigitalSensorDuman.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorDuman.Dock = DockStyle.Fill;
            DigitalSensorDuman.Location = new Point(191, 50);
            DigitalSensorDuman.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorDuman.Name = "DigitalSensorDuman";
            DigitalSensorDuman.Padding = new Padding(1);
            DigitalSensorDuman.SensorDescription = "Kabin içi duman durumu";
            DigitalSensorDuman.SensorName = "Duman";
            DigitalSensorDuman.Size = new Size(188, 50);
            DigitalSensorDuman.TabIndex = 1;
            // 
            // DigitalSensorSuBaskini
            // 
            DigitalSensorSuBaskini.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorSuBaskini.Dock = DockStyle.Fill;
            DigitalSensorSuBaskini.Location = new Point(382, 50);
            DigitalSensorSuBaskini.Margin = new Padding(0);
            DigitalSensorSuBaskini.Name = "DigitalSensorSuBaskini";
            DigitalSensorSuBaskini.Padding = new Padding(1);
            DigitalSensorSuBaskini.SensorDescription = "Kabiniçi su baskını";
            DigitalSensorSuBaskini.SensorName = "Su Baskını";
            DigitalSensorSuBaskini.Size = new Size(192, 50);
            DigitalSensorSuBaskini.TabIndex = 1;
            // 
            // DigitalSensorPompa2Termik
            // 
            DigitalSensorPompa2Termik.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorPompa2Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa2Termik.Location = new Point(382, 100);
            DigitalSensorPompa2Termik.Margin = new Padding(0);
            DigitalSensorPompa2Termik.Name = "DigitalSensorPompa2Termik";
            DigitalSensorPompa2Termik.Padding = new Padding(1);
            DigitalSensorPompa2Termik.SensorDescription = "Pompa 2 Termik atma durumu";
            DigitalSensorPompa2Termik.SensorName = "Pompa 2 Termik";
            DigitalSensorPompa2Termik.Size = new Size(192, 50);
            DigitalSensorPompa2Termik.TabIndex = 1;
            // 
            // DigitalSensorPompa1Termik
            // 
            DigitalSensorPompa1Termik.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorPompa1Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa1Termik.Location = new Point(191, 100);
            DigitalSensorPompa1Termik.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorPompa1Termik.Name = "DigitalSensorPompa1Termik";
            DigitalSensorPompa1Termik.Padding = new Padding(1);
            DigitalSensorPompa1Termik.SensorDescription = "Pompa 1 Termik atma durumu";
            DigitalSensorPompa1Termik.SensorName = "Pompa 1 Termik";
            DigitalSensorPompa1Termik.Size = new Size(188, 50);
            DigitalSensorPompa1Termik.TabIndex = 1;
            // 
            // DigitalSensorAcilStop
            // 
            DigitalSensorAcilStop.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorAcilStop.Dock = DockStyle.Fill;
            DigitalSensorAcilStop.Location = new Point(0, 100);
            DigitalSensorAcilStop.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorAcilStop.Name = "DigitalSensorAcilStop";
            DigitalSensorAcilStop.Padding = new Padding(1);
            DigitalSensorAcilStop.SensorDescription = "Acil Stop butonu durumu";
            DigitalSensorAcilStop.SensorName = "Acil Stop";
            DigitalSensorAcilStop.Size = new Size(188, 50);
            DigitalSensorAcilStop.TabIndex = 1;
            // 
            // DigitalSensorTSuPompaTermik
            // 
            DigitalSensorTSuPompaTermik.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorTSuPompaTermik.Dock = DockStyle.Fill;
            DigitalSensorTSuPompaTermik.Location = new Point(0, 150);
            DigitalSensorTSuPompaTermik.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorTSuPompaTermik.Name = "DigitalSensorTSuPompaTermik";
            DigitalSensorTSuPompaTermik.Padding = new Padding(1);
            DigitalSensorTSuPompaTermik.SensorDescription = "Temiz Su P. Termik atma durumu";
            DigitalSensorTSuPompaTermik.SensorName = "T. Su Pompa Termik";
            DigitalSensorTSuPompaTermik.Size = new Size(188, 50);
            DigitalSensorTSuPompaTermik.TabIndex = 1;
            // 
            // DigitalSensorYikamaTanki
            // 
            DigitalSensorYikamaTanki.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorYikamaTanki.Dock = DockStyle.Fill;
            DigitalSensorYikamaTanki.Location = new Point(191, 150);
            DigitalSensorYikamaTanki.Margin = new Padding(0, 0, 3, 0);
            DigitalSensorYikamaTanki.Name = "DigitalSensorYikamaTanki";
            DigitalSensorYikamaTanki.Padding = new Padding(1);
            DigitalSensorYikamaTanki.SensorDescription = "Yıkama Tankı dolu/boş bilgisi";
            DigitalSensorYikamaTanki.SensorName = "Yıkama Tankı";
            DigitalSensorYikamaTanki.Size = new Size(188, 50);
            DigitalSensorYikamaTanki.TabIndex = 1;
            // 
            // DigitalSensorEnerji
            // 
            DigitalSensorEnerji.BackColor = Color.FromArgb(230, 230, 230);
            DigitalSensorEnerji.Dock = DockStyle.Fill;
            DigitalSensorEnerji.Location = new Point(382, 150);
            DigitalSensorEnerji.Margin = new Padding(0);
            DigitalSensorEnerji.Name = "DigitalSensorEnerji";
            DigitalSensorEnerji.Padding = new Padding(1);
            DigitalSensorEnerji.SensorDescription = "Kabin elektrik enerjisi durumu";
            DigitalSensorEnerji.SensorName = "Enerji";
            DigitalSensorEnerji.Size = new Size(192, 50);
            DigitalSensorEnerji.TabIndex = 1;
            // 
            // digitalSensorBar1
            // 
            digitalSensorBar1.BackColor = Color.FromArgb(235, 235, 235);
            digitalSensorBar1.ChannelDescription = "SENSÖR İSİMLERİ";
            digitalSensorBar1.ChannelName = "DİJİTAL SENSÖRLER";
            digitalSensorBar1.ChannelStateColor = Color.FromArgb(0, 131, 200);
            tableLayoutPanel3.SetColumnSpan(digitalSensorBar1, 3);
            digitalSensorBar1.DataStateColor = Color.White;
            digitalSensorBar1.DataStateDescription = "-";
            digitalSensorBar1.DataStateDescriptionColor = SystemColors.ControlText;
            digitalSensorBar1.DataStateTitleColor = SystemColors.ControlText;
            digitalSensorBar1.Dock = DockStyle.Fill;
            digitalSensorBar1.Location = new Point(0, 0);
            digitalSensorBar1.Margin = new Padding(0);
            digitalSensorBar1.Name = "digitalSensorBar1";
            digitalSensorBar1.Size = new Size(574, 50);
            digitalSensorBar1.SystemStateDescription = "-";
            digitalSensorBar1.SystemStateDescriptionColor = SystemColors.ControlText;
            digitalSensorBar1.SystemStateTitleColor = SystemColors.ControlText;
            digitalSensorBar1.TabIndex = 2;
            // 
            // StationInfoControl
            // 
            StationInfoControl.BackColor = Color.FromArgb(230, 230, 230);
            StationInfoControl.Dock = DockStyle.Fill;
            StationInfoControl.IletkenlikCalibration = "     -";
            StationInfoControl.IletkenlikCalibrationImage = null;
            StationInfoControl.LastWashAkm = "     -";
            StationInfoControl.LastWashAkmImage = null;
            StationInfoControl.LastWashCozunmusOksijen = "     -";
            StationInfoControl.LastWashCozunmusOksijenImage = null;
            StationInfoControl.LastWashDebi = "     -";
            StationInfoControl.LastWashDebiImage = null;
            StationInfoControl.LastWashDesarjDebi = "     -";
            StationInfoControl.LastWashDesarjDebiImage = null;
            StationInfoControl.LastWashHariciDebi = "     -";
            StationInfoControl.LastWashHariciDebi2 = "     -";
            StationInfoControl.LastWashHariciDebi2Image = null;
            StationInfoControl.LastWashHariciDebiImage = null;
            StationInfoControl.LastWashIletkenlik = "     -";
            StationInfoControl.LastWashIletkenlikImage = null;
            StationInfoControl.LastWashKoi = "     -";
            StationInfoControl.LastWashKoiImage = null;
            StationInfoControl.LastWashPh = "     -";
            StationInfoControl.LastWashPhImage = null;
            StationInfoControl.LastWashSicaklik = "     -";
            StationInfoControl.LastWashSicaklikImage = null;
            StationInfoControl.LastWashWeekAkm = "     -";
            StationInfoControl.LastWashWeekAkmImage = null;
            StationInfoControl.LastWashWeekCozunmusOksijen = "     -";
            StationInfoControl.LastWashWeekCozunmusOksijenImage = null;
            StationInfoControl.LastWashWeekDebi = "     -";
            StationInfoControl.LastWashWeekDebiImage = null;
            StationInfoControl.LastWashWeekDesarjDebi = "     -";
            StationInfoControl.LastWashWeekDesarjDebiImage = null;
            StationInfoControl.LastWashWeekHariciDebi = "     -";
            StationInfoControl.LastWashWeekHariciDebi2 = "     -";
            StationInfoControl.LastWashWeekHariciDebi2Image = null;
            StationInfoControl.LastWashWeekHariciDebiImage = null;
            StationInfoControl.LastWashWeekIletkenlik = "     -";
            StationInfoControl.LastWashWeekIletkenlikImage = null;
            StationInfoControl.LastWashWeekKoi = "     -";
            StationInfoControl.LastWashWeekKoiImage = null;
            StationInfoControl.LastWashWeekPh = "     -";
            StationInfoControl.LastWashWeekPhImage = null;
            StationInfoControl.LastWashWeekSicaklik = "     -";
            StationInfoControl.LastWashWeekSicaklikImage = null;
            StationInfoControl.Location = new Point(588, 219);
            StationInfoControl.Name = "StationInfoControl";
            StationInfoControl.Padding = new Padding(1);
            StationInfoControl.PhCalibration = "     -";
            StationInfoControl.PhCalibrationImage = null;
            StationInfoControl.Size = new Size(574, 414);
            StationInfoControl.TabIndex = 4;
            // 
            // StatusBarControl
            // 
            StatusBarControl.BackColor = Color.FromArgb(230, 230, 230);
            tableLayoutPanel1.SetColumnSpan(StatusBarControl, 2);
            StatusBarControl.ConnectionStatement = "Bağlantı Durumu:";
            StatusBarControl.ConnectionTime = "Bağlantı Zamanı:";
            StatusBarControl.Dock = DockStyle.Fill;
            StatusBarControl.GunlukYikamaKalan = "G. Yıkamaya Kalan: ";
            StatusBarControl.HaftalikYikamaKalan = "H. Yıkamaya Kalan: ";
            StatusBarControl.Location = new Point(8, 639);
            StatusBarControl.Name = "StatusBarControl";
            StatusBarControl.Padding = new Padding(1);
            StatusBarControl.SistemSaati = "Sistem Saati: ";
            StatusBarControl.Size = new Size(1154, 30);
            StatusBarControl.TabIndex = 5;
            // 
            // TimerAssignUI
            // 
            TimerAssignUI.Enabled = true;
            TimerAssignUI.Interval = 5000;
            TimerAssignUI.Tick += TimerAssignUI_Tick;
            // 
            // TimerGetMissingDates
            // 
            TimerGetMissingDates.Enabled = true;
            TimerGetMissingDates.Interval = 1200000;
            TimerGetMissingDates.Tick += TimerGetMissingDates_Tick;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "HomePage";
            Size = new Size(1170, 677);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private async void TimerAssignUI_Tick(object sender, EventArgs e)
        {
            try
            {
                var value = await ReadPlcDataAsync();

                ChannelAkm.InstantData              = $"{value.Analog.Akm} mg/l";
                ChannelCozunmusOksijen.InstantData  = $"{value.Analog.CozunmusOksijen} mg/l";
                ChannelSicaklik.InstantData         = $"{value.Analog.Sicaklik} mg/l";
                ChannelPh.InstantData               = $"{value.Analog.Ph} mg/l";
                ChannelIletkenlik.InstantData       = $"{value.Analog.Iletkenlik} mg/l";
                ChannelKoi.InstantData              = $"{value.Analog.Koi} mg/l";
                ChannelAkisHizi.InstantData         = $"{value.Analog.AkisHizi} mg/l";
                ChannelDebi.InstantData             = $"{value.Analog.Debi} mg/l";

                DigitalSensorKapi.SensorState        = value.Digital.Kapi ? StateColors.Error : StateColors.Ok;
                DigitalSensorDuman.SensorState       = value.Digital.Duman ? StateColors.Error : StateColors.Ok;
                DigitalSensorSuBaskini.SensorState   = value.Digital.SuBaskini ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa2Termik.SensorState = value.Digital.Pompa2Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa1Termik.SensorState = value.Digital.Pompa1Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorAcilStop.SensorState    = value.Digital.AcilStop ? StateColors.Error : StateColors.Ok;
                DigitalSensorTSuPompaTermik.SensorState = value.Digital.TemizSuTermik ? StateColors.Error : StateColors.Ok;
                DigitalSensorYikamaTanki.SensorState = value.Digital.YikamaTanki ? StateColors.Error : StateColors.Ok;
                DigitalSensorEnerji.SensorState      = value.Digital.Enerji ? StateColors.Error : StateColors.Ok;
                StatusBarControl.SistemSaati        = $"Sistem Saati: {value.TimeParameter.SystemTime:g}";
                StatusBarControl.GunlukYikamaKalan  =
                    $"G. Yıkamaya Kalan: {value.TimeParameter.DailyWashHour:D2}:{value.TimeParameter.Minute:D2}:{value.TimeParameter.Second:D2}";
                StatusBarControl.HaftalikYikamaKalan =
                    $"H. Yıkamaya Kalan: {value.TimeParameter.WeeklyWashDay:D2}:{value.TimeParameter.WeeklyWashHour:D2}:{value.TimeParameter.Minute:D2}:{value.TimeParameter.Second:D2}";

                foreach (var ch in _channels)
                    ch.ChannelStatement = StateColors.Ok;

                digitalSensorBar1.SystemStateDescription = "BAĞLI";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Ok;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Ok;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı";

                _connectedSince ??= DateTime.Now;
                var elapsed = DateTime.Now - _connectedSince.Value;
                StatusBarControl.ConnectionTime = $"Bağlantı Zamanı: {elapsed:hh\\:mm\\:ss}";
            }
            catch
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "HATA";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Error;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                StatusBarControl.ConnectionTime = "-";
                _connectedSince = null;
            }
        }

        private void TimerGetMissingDates_Tick(object sender, EventArgs e)
        {
            if (_connectedSince.HasValue)
            {
                var elapsed = DateTime.Now - _connectedSince.Value;
                StatusBarControl.ConnectionTime = $"Bağlantı Zamanı: {elapsed:hh\\:mm\\:ss}";
            }
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Controls.IBKS.ChannelControl channelControl1;
        private Controls.IBKS.DigitalSensorControl DigitalSensorKapi;
        private Controls.IBKS.DigitalSensorControl DigitalSensorDuman;
        private Controls.IBKS.DigitalSensorControl DigitalSensorSuBaskini;
        private Controls.IBKS.DigitalSensorControl DigitalSensorPompa2Termik;
        private Controls.IBKS.DigitalSensorControl DigitalSensorPompa1Termik;
        private Controls.IBKS.DigitalSensorControl DigitalSensorAcilStop;
        private Controls.IBKS.DigitalSensorControl DigitalSensorTSuPompaTermik;
        private Controls.IBKS.DigitalSensorControl DigitalSensorYikamaTanki;
        private Controls.IBKS.DigitalSensorControl DigitalSensorEnerji;
        private Controls.IBKS.ChannelControl ChannelDebi;
        private Controls.IBKS.ChannelControl ChannelAkisHizi;
        private Controls.IBKS.ChannelControl ChannelKoi;
        private Controls.IBKS.ChannelControl ChannelIletkenlik;
        private Controls.IBKS.ChannelControl ChannelPh;
        private Controls.IBKS.ChannelControl ChannelSicaklik;
        private Controls.IBKS.ChannelControl ChannelCozunmusOksijen;
        private Controls.IBKS.StationInfoControl StationInfoControl;
        private System.Windows.Forms.Timer TimerAssignUI;
        private Controls.IBKS.StatusBarControl StatusBarControl;
        private System.Windows.Forms.Timer TimerGetMissingDates;
        private Controls.IBKS.ChannelControl ChannelAkm;
        private Controls.IBKS.DigitalSensorBar digitalSensorBar1;
    }
}
