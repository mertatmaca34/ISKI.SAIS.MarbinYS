﻿
namespace WinUI.Pages
{
    partial class SimulationPage
    {
        /// <summary>
        /// Required designer variable.
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
            PanelWaterTank = new Panel();
            LabelNem = new Label();
            label27 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            LabelSicaklik = new Label();
            label25 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            LabelFrekans = new Label();
            label23 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            LabelAktifPompa = new Label();
            label21 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            LabelHariciDebi2 = new Label();
            label19 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            LabelHariciDebi = new Label();
            label17 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            LabelDesarjDebi = new Label();
            label15 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            LabelDebi = new Label();
            label13 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            LabelAkisHizi = new Label();
            label11 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            LabelOksijen = new Label();
            label9 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            LabelIletkenlik = new Label();
            label7 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            LabelPh = new Label();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            LabelKoi = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            LabelAkm = new Label();
            PictureBoxPump2 = new PictureBox();
            PictureBoxPump1 = new PictureBox();
            TimerSimulation = new System.Windows.Forms.Timer(components);
            PanelDoor = new Panel();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump1).BeginInit();
            SuspendLayout();
            // 
            // PanelWaterTank
            // 
            PanelWaterTank.BackColor = Color.Transparent;
            PanelWaterTank.BackgroundImage = Properties.Resources.water_tank_empty;
            PanelWaterTank.BackgroundImageLayout = ImageLayout.None;
            PanelWaterTank.Location = new Point(341, 45);
            PanelWaterTank.Name = "PanelWaterTank";
            PanelWaterTank.Size = new Size(87, 230);
            PanelWaterTank.TabIndex = 4;
            // 
            // LabelNem
            // 
            LabelNem.Anchor = AnchorStyles.Top;
            LabelNem.AutoSize = true;
            LabelNem.BackColor = Color.Transparent;
            LabelNem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNem.ForeColor = Color.Lime;
            LabelNem.Location = new Point(30, 20);
            LabelNem.Name = "LabelNem";
            LabelNem.Size = new Size(14, 15);
            LabelNem.TabIndex = 2;
            LabelNem.Text = "0";
            LabelNem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Bottom;
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(20, 5);
            label27.Name = "label27";
            label27.Size = new Size(33, 15);
            label27.TabIndex = 2;
            label27.Text = "Nem";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.Transparent;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label27, 0, 0);
            tableLayoutPanel14.Controls.Add(LabelNem, 0, 1);
            tableLayoutPanel14.Location = new Point(197, 224);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(74, 40);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // LabelSicaklik
            // 
            LabelSicaklik.Anchor = AnchorStyles.Top;
            LabelSicaklik.AutoSize = true;
            LabelSicaklik.BackColor = Color.Transparent;
            LabelSicaklik.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSicaklik.ForeColor = Color.Lime;
            LabelSicaklik.Location = new Point(30, 20);
            LabelSicaklik.Name = "LabelSicaklik";
            LabelSicaklik.Size = new Size(14, 15);
            LabelSicaklik.TabIndex = 2;
            LabelSicaklik.Text = "0";
            LabelSicaklik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Bottom;
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(11, 5);
            label25.Name = "label25";
            label25.Size = new Size(52, 15);
            label25.TabIndex = 2;
            label25.Text = "Sıcaklık";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.BackColor = Color.Transparent;
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label25, 0, 0);
            tableLayoutPanel13.Controls.Add(LabelSicaklik, 0, 1);
            tableLayoutPanel13.Location = new Point(197, 175);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(74, 40);
            tableLayoutPanel13.TabIndex = 3;
            // 
            // LabelFrekans
            // 
            LabelFrekans.Anchor = AnchorStyles.Top;
            LabelFrekans.AutoSize = true;
            LabelFrekans.BackColor = Color.Transparent;
            LabelFrekans.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFrekans.ForeColor = Color.Lime;
            LabelFrekans.Location = new Point(30, 20);
            LabelFrekans.Name = "LabelFrekans";
            LabelFrekans.Size = new Size(14, 15);
            LabelFrekans.TabIndex = 2;
            LabelFrekans.Text = "0";
            LabelFrekans.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Bottom;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(10, 5);
            label23.Name = "label23";
            label23.Size = new Size(53, 15);
            label23.TabIndex = 2;
            label23.Text = "Frekans";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = Color.Transparent;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label23, 0, 0);
            tableLayoutPanel12.Controls.Add(LabelFrekans, 0, 1);
            tableLayoutPanel12.Location = new Point(198, 112);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(74, 40);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // LabelAktifPompa
            // 
            LabelAktifPompa.Anchor = AnchorStyles.Top;
            LabelAktifPompa.AutoSize = true;
            LabelAktifPompa.BackColor = Color.Transparent;
            LabelAktifPompa.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAktifPompa.ForeColor = Color.Lime;
            LabelAktifPompa.Location = new Point(21, 20);
            LabelAktifPompa.Name = "LabelAktifPompa";
            LabelAktifPompa.Size = new Size(31, 15);
            LabelAktifPompa.TabIndex = 2;
            LabelAktifPompa.Text = "YOK";
            LabelAktifPompa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom;
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(11, 5);
            label21.Name = "label21";
            label21.Size = new Size(51, 15);
            label21.TabIndex = 2;
            label21.Text = "AKTİF P.";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label21, 0, 0);
            tableLayoutPanel11.Controls.Add(LabelAktifPompa, 0, 1);
            tableLayoutPanel11.Location = new Point(198, 64);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(74, 40);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // LabelHariciDebi2
            // 
            LabelHariciDebi2.Anchor = AnchorStyles.Top;
            LabelHariciDebi2.AutoSize = true;
            LabelHariciDebi2.BackColor = Color.Transparent;
            LabelHariciDebi2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHariciDebi2.ForeColor = Color.Lime;
            LabelHariciDebi2.Location = new Point(30, 20);
            LabelHariciDebi2.Name = "LabelHariciDebi2";
            LabelHariciDebi2.Size = new Size(14, 15);
            LabelHariciDebi2.TabIndex = 2;
            LabelHariciDebi2.Text = "0";
            LabelHariciDebi2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(9, 5);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 2;
            label19.Text = "H. Debi 2";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.Transparent;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label19, 0, 0);
            tableLayoutPanel10.Controls.Add(LabelHariciDebi2, 0, 1);
            tableLayoutPanel10.Location = new Point(273, 621);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(74, 40);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // LabelHariciDebi
            // 
            LabelHariciDebi.Anchor = AnchorStyles.Top;
            LabelHariciDebi.AutoSize = true;
            LabelHariciDebi.BackColor = Color.Transparent;
            LabelHariciDebi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHariciDebi.ForeColor = Color.Lime;
            LabelHariciDebi.Location = new Point(30, 20);
            LabelHariciDebi.Name = "LabelHariciDebi";
            LabelHariciDebi.Size = new Size(14, 15);
            LabelHariciDebi.TabIndex = 2;
            LabelHariciDebi.Text = "0";
            LabelHariciDebi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(14, 5);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 2;
            label17.Text = "H. Debi";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = Color.Transparent;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label17, 0, 0);
            tableLayoutPanel9.Controls.Add(LabelHariciDebi, 0, 1);
            tableLayoutPanel9.Location = new Point(185, 621);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(74, 40);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // LabelDesarjDebi
            // 
            LabelDesarjDebi.Anchor = AnchorStyles.Top;
            LabelDesarjDebi.AutoSize = true;
            LabelDesarjDebi.BackColor = Color.Transparent;
            LabelDesarjDebi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDesarjDebi.ForeColor = Color.Lime;
            LabelDesarjDebi.Location = new Point(30, 20);
            LabelDesarjDebi.Name = "LabelDesarjDebi";
            LabelDesarjDebi.Size = new Size(14, 15);
            LabelDesarjDebi.TabIndex = 2;
            LabelDesarjDebi.Text = "0";
            LabelDesarjDebi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(7, 5);
            label15.Name = "label15";
            label15.Size = new Size(60, 15);
            label15.TabIndex = 2;
            label15.Text = "Deş. Debi";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label15, 0, 0);
            tableLayoutPanel8.Controls.Add(LabelDesarjDebi, 0, 1);
            tableLayoutPanel8.Location = new Point(97, 621);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(74, 40);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // LabelDebi
            // 
            LabelDebi.Anchor = AnchorStyles.Top;
            LabelDebi.AutoSize = true;
            LabelDebi.BackColor = Color.Transparent;
            LabelDebi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDebi.ForeColor = Color.Lime;
            LabelDebi.Location = new Point(30, 20);
            LabelDebi.Name = "LabelDebi";
            LabelDebi.Size = new Size(14, 15);
            LabelDebi.TabIndex = 2;
            LabelDebi.Text = "0";
            LabelDebi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(21, 5);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 2;
            label13.Text = "Debi";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label13, 0, 0);
            tableLayoutPanel7.Controls.Add(LabelDebi, 0, 1);
            tableLayoutPanel7.Location = new Point(329, 503);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(74, 40);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // LabelAkisHizi
            // 
            LabelAkisHizi.Anchor = AnchorStyles.Top;
            LabelAkisHizi.AutoSize = true;
            LabelAkisHizi.BackColor = Color.Transparent;
            LabelAkisHizi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAkisHizi.ForeColor = Color.Lime;
            LabelAkisHizi.Location = new Point(30, 20);
            LabelAkisHizi.Name = "LabelAkisHizi";
            LabelAkisHizi.Size = new Size(14, 15);
            LabelAkisHizi.TabIndex = 2;
            LabelAkisHizi.Text = "0";
            LabelAkisHizi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 5);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 2;
            label11.Text = "Akış Hızı";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label11, 0, 0);
            tableLayoutPanel6.Controls.Add(LabelAkisHizi, 0, 1);
            tableLayoutPanel6.Location = new Point(760, 379);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(74, 40);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // LabelOksijen
            // 
            LabelOksijen.Anchor = AnchorStyles.Top;
            LabelOksijen.AutoSize = true;
            LabelOksijen.BackColor = Color.Transparent;
            LabelOksijen.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOksijen.ForeColor = Color.Lime;
            LabelOksijen.Location = new Point(30, 20);
            LabelOksijen.Name = "LabelOksijen";
            LabelOksijen.Size = new Size(14, 15);
            LabelOksijen.TabIndex = 2;
            LabelOksijen.Text = "0";
            LabelOksijen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 5);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 2;
            label9.Text = "Oksijen";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(LabelOksijen, 0, 1);
            tableLayoutPanel5.Location = new Point(760, 239);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(74, 40);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // LabelIletkenlik
            // 
            LabelIletkenlik.Anchor = AnchorStyles.Top;
            LabelIletkenlik.AutoSize = true;
            LabelIletkenlik.BackColor = Color.Transparent;
            LabelIletkenlik.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelIletkenlik.ForeColor = Color.Lime;
            LabelIletkenlik.Location = new Point(30, 20);
            LabelIletkenlik.Name = "LabelIletkenlik";
            LabelIletkenlik.Size = new Size(14, 15);
            LabelIletkenlik.TabIndex = 2;
            LabelIletkenlik.Text = "0";
            LabelIletkenlik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 2;
            label7.Text = "İletkenlik";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(LabelIletkenlik, 0, 1);
            tableLayoutPanel4.Location = new Point(760, 197);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(74, 40);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // LabelPh
            // 
            LabelPh.Anchor = AnchorStyles.Top;
            LabelPh.AutoSize = true;
            LabelPh.BackColor = Color.Transparent;
            LabelPh.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPh.ForeColor = Color.Lime;
            LabelPh.Location = new Point(30, 20);
            LabelPh.Name = "LabelPh";
            LabelPh.Size = new Size(14, 15);
            LabelPh.TabIndex = 2;
            LabelPh.Text = "0";
            LabelPh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 5);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 2;
            label5.Text = "pH";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(LabelPh, 0, 1);
            tableLayoutPanel3.Location = new Point(760, 125);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(74, 40);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // LabelKoi
            // 
            LabelKoi.Anchor = AnchorStyles.Top;
            LabelKoi.AutoSize = true;
            LabelKoi.BackColor = Color.Transparent;
            LabelKoi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKoi.ForeColor = Color.Lime;
            LabelKoi.Location = new Point(30, 20);
            LabelKoi.Name = "LabelKoi";
            LabelKoi.Size = new Size(14, 15);
            LabelKoi.TabIndex = 2;
            LabelKoi.Text = "0";
            LabelKoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 5);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "KOi";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(LabelKoi, 0, 1);
            tableLayoutPanel2.Location = new Point(1034, 174);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(74, 40);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelAkm, 0, 1);
            tableLayoutPanel1.Location = new Point(1034, 121);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(74, 40);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 5);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "AKM";
            // 
            // LabelAkm
            // 
            LabelAkm.Anchor = AnchorStyles.Top;
            LabelAkm.AutoSize = true;
            LabelAkm.BackColor = Color.Transparent;
            LabelAkm.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAkm.ForeColor = Color.Lime;
            LabelAkm.Location = new Point(30, 20);
            LabelAkm.Name = "LabelAkm";
            LabelAkm.Size = new Size(14, 15);
            LabelAkm.TabIndex = 2;
            LabelAkm.Text = "0";
            LabelAkm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBoxPump2
            // 
            PictureBoxPump2.BackColor = Color.Transparent;
            PictureBoxPump2.Image = Properties.Resources.pump2_idle;
            PictureBoxPump2.Location = new Point(908, 476);
            PictureBoxPump2.Name = "PictureBoxPump2";
            PictureBoxPump2.Size = new Size(70, 76);
            PictureBoxPump2.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxPump2.TabIndex = 1;
            PictureBoxPump2.TabStop = false;
            // 
            // PictureBoxPump1
            // 
            PictureBoxPump1.BackColor = Color.Transparent;
            PictureBoxPump1.Image = Properties.Resources.pump1_idle;
            PictureBoxPump1.Location = new Point(775, 476);
            PictureBoxPump1.Name = "PictureBoxPump1";
            PictureBoxPump1.Size = new Size(70, 76);
            PictureBoxPump1.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxPump1.TabIndex = 1;
            PictureBoxPump1.TabStop = false;
            // 
            // TimerSimulation
            // 
            TimerSimulation.Enabled = true;
            TimerSimulation.Interval = 1000;
            TimerSimulation.Tick += TimerSimulation_Tick;
            // 
            // PanelDoor
            // 
            PanelDoor.BackColor = Color.Transparent;
            PanelDoor.BackgroundImage = Properties.Resources.door_closed;
            PanelDoor.BackgroundImageLayout = ImageLayout.None;
            PanelDoor.Location = new Point(947, 616);
            PanelDoor.Name = "PanelDoor";
            PanelDoor.Size = new Size(127, 63);
            PanelDoor.TabIndex = 0;
            // 
            // SimulationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.system_auto1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1170, 677);
            Controls.Add(PanelWaterTank);
            Controls.Add(tableLayoutPanel10);
            Controls.Add(tableLayoutPanel9);
            Controls.Add(tableLayoutPanel8);
            Controls.Add(tableLayoutPanel14);
            Controls.Add(tableLayoutPanel13);
            Controls.Add(tableLayoutPanel12);
            Controls.Add(tableLayoutPanel11);
            Controls.Add(tableLayoutPanel7);
            Controls.Add(tableLayoutPanel6);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PictureBoxPump2);
            Controls.Add(PictureBoxPump1);
            Controls.Add(PanelDoor);
            DoubleBuffered = true;
            Name = "SimulationPage";
            Text = "SimulationPage";
            SizeChanged += SimulationPage_SizeChanged;
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TimerSimulation_Tick(object sender, EventArgs e)
        {
        }

        private void SimulationPage_SizeChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private Panel PanelWaterTank;
        private Label LabelNem;
        private Label label27;
        private TableLayoutPanel tableLayoutPanel14;
        private Label LabelSicaklik;
        private Label label25;
        private TableLayoutPanel tableLayoutPanel13;
        private Label LabelFrekans;
        private Label label23;
        private TableLayoutPanel tableLayoutPanel12;
        private Label LabelAktifPompa;
        private Label label21;
        private TableLayoutPanel tableLayoutPanel11;
        private Label LabelHariciDebi2;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel10;
        private Label LabelHariciDebi;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel9;
        private Label LabelDesarjDebi;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel8;
        private Label LabelDebi;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel7;
        private Label LabelAkisHizi;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel6;
        private Label LabelOksijen;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LabelIletkenlik;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LabelPh;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LabelKoi;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label LabelAkm;
        private PictureBox PictureBoxPump2;
        private PictureBox PictureBoxPump1;
        private System.Windows.Forms.Timer TimerSimulation;
        private Panel PanelDoor;
    }
}
