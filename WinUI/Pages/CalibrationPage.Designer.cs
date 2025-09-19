﻿using System.Windows.Forms.DataVisualization.Charting;
using WinUI.Controls.IBKS;

namespace WinUI.Pages
{
    partial class CalibrationPage
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Series series2 = new Series();
            Title title1 = new Title();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel23 = new TableLayoutPanel();
            tableLayoutPanel24 = new TableLayoutPanel();
            panel16 = new Panel();
            tableLayoutPanel25 = new TableLayoutPanel();
            label21 = new Label();
            label22 = new Label();
            ButtonKoiZero = new System.Windows.Forms.Button();
            panel19 = new Panel();
            panel20 = new Panel();
            tableLayoutPanel26 = new TableLayoutPanel();
            label23 = new Label();
            LabelKoiLastCalibration = new Label();
            tableLayoutPanel19 = new TableLayoutPanel();
            tableLayoutPanel20 = new TableLayoutPanel();
            ButtonIletkenlikSpan = new System.Windows.Forms.Button();
            panel14 = new Panel();
            tableLayoutPanel21 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            ButtonIletkenlikZero = new System.Windows.Forms.Button();
            panel15 = new Panel();
            panel17 = new Panel();
            tableLayoutPanel22 = new TableLayoutPanel();
            label19 = new Label();
            LabelIletkenlikLastCalibration = new Label();
            panel18 = new Panel();
            tableLayoutPanel15 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            ButtonPhSpan = new System.Windows.Forms.Button();
            panel10 = new Panel();
            tableLayoutPanel17 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            ButtonPhZero = new System.Windows.Forms.Button();
            panel11 = new Panel();
            panel12 = new Panel();
            tableLayoutPanel18 = new TableLayoutPanel();
            label15 = new Label();
            LabelPhLastCalibration = new Label();
            panel13 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            ButtonAkmZero = new System.Windows.Forms.Button();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            LabelAkmLastCalibration = new Label();
            titleBarControl1 = new TitleBarControl();
            tableLayoutPanel27 = new TableLayoutPanel();
            TitleBarControlActiveCalibration = new TitleBarControl();
            CalibrationStatusBarZero = new CalibrationStatusBarZeroControl();
            CalibrationStatusBarSpan = new CalibrationStatusBarSpanControl();
            tableLayoutPanel28 = new TableLayoutPanel();
            TitleBarControlTimeRemain = new TitleBarControl();
            titleBarControl3 = new TitleBarControl();
            tableLayoutPanel29 = new TableLayoutPanel();
            ChartCalibration = new Chart();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            button2 = new System.Windows.Forms.Button();
            panel5 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel10 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            panel7 = new Panel();
            tableLayoutPanel13 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            button3 = new System.Windows.Forms.Button();
            panel8 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel14 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel23.SuspendLayout();
            tableLayoutPanel24.SuspendLayout();
            tableLayoutPanel25.SuspendLayout();
            tableLayoutPanel26.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel28.SuspendLayout();
            tableLayoutPanel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartCalibration).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel27, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel28, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel29, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel23, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel19, 0, 4);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel15, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Margin = new Padding(8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(569, 306);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel23.ColumnCount = 1;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.Controls.Add(tableLayoutPanel24, 0, 0);
            tableLayoutPanel23.Dock = DockStyle.Fill;
            tableLayoutPanel23.Location = new Point(3, 108);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 1;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel23.Size = new Size(563, 61);
            tableLayoutPanel23.TabIndex = 7;
            // 
            // tableLayoutPanel24
            // 
            tableLayoutPanel24.BackColor = Color.White;
            tableLayoutPanel24.ColumnCount = 6;
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel24.Controls.Add(panel16, 0, 0);
            tableLayoutPanel24.Controls.Add(tableLayoutPanel25, 1, 0);
            tableLayoutPanel24.Controls.Add(ButtonKoiZero, 5, 0);
            tableLayoutPanel24.Controls.Add(panel19, 2, 0);
            tableLayoutPanel24.Controls.Add(panel20, 4, 0);
            tableLayoutPanel24.Controls.Add(tableLayoutPanel26, 3, 0);
            tableLayoutPanel24.Dock = DockStyle.Fill;
            tableLayoutPanel24.Location = new Point(1, 1);
            tableLayoutPanel24.Margin = new Padding(1);
            tableLayoutPanel24.Name = "tableLayoutPanel24";
            tableLayoutPanel24.RowCount = 1;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel24.Size = new Size(561, 59);
            tableLayoutPanel24.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Gray;
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(8, 59);
            panel16.TabIndex = 2;
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.ColumnCount = 1;
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel25.Controls.Add(label21, 0, 1);
            tableLayoutPanel25.Controls.Add(label22, 0, 0);
            tableLayoutPanel25.Dock = DockStyle.Fill;
            tableLayoutPanel25.Location = new Point(11, 3);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.RowCount = 2;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel25.Size = new Size(170, 53);
            tableLayoutPanel25.TabIndex = 2;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 8.25F);
            label21.Location = new Point(23, 26);
            label21.Name = "label21";
            label21.Size = new Size(124, 14);
            label21.TabIndex = 2;
            label21.Text = "Kimyasal Oksijen İhtiyacı";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Bottom;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label22.Location = new Point(69, 8);
            label22.Name = "label22";
            label22.Size = new Size(32, 18);
            label22.TabIndex = 2;
            label22.Text = "Koi";
            // 
            // ButtonKoiZero
            // 
            ButtonKoiZero.BackColor = Color.FromArgb(0, 131, 200);
            ButtonKoiZero.Dock = DockStyle.Fill;
            ButtonKoiZero.FlatAppearance.BorderSize = 0;
            ButtonKoiZero.ForeColor = Color.White;
            ButtonKoiZero.Location = new Point(395, 15);
            ButtonKoiZero.Margin = new Padding(15);
            ButtonKoiZero.Name = "ButtonKoiZero";
            ButtonKoiZero.Size = new Size(151, 29);
            ButtonKoiZero.TabIndex = 4;
            ButtonKoiZero.Text = "ZERO";
            ButtonKoiZero.UseVisualStyleBackColor = false;
            //ButtonKoiZero.Click += ButtonKoiZero_Click;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.None;
            panel19.BackColor = Color.FromArgb(235, 235, 235);
            panel19.Location = new Point(188, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(1, 50);
            panel19.TabIndex = 2;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.None;
            panel20.BackColor = Color.FromArgb(235, 235, 235);
            panel20.Location = new Point(374, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(1, 50);
            panel20.TabIndex = 2;
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 1;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.Controls.Add(label23, 0, 1);
            tableLayoutPanel26.Controls.Add(LabelKoiLastCalibration, 0, 0);
            tableLayoutPanel26.Dock = DockStyle.Fill;
            tableLayoutPanel26.Location = new Point(197, 3);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 2;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.Size = new Size(170, 53);
            tableLayoutPanel26.TabIndex = 3;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 8.25F);
            label23.Location = new Point(28, 26);
            label23.Name = "label23";
            label23.Size = new Size(114, 14);
            label23.TabIndex = 2;
            label23.Text = "Son Kalibrasyon Tarihi";
            // 
            // LabelKoiLastCalibration
            // 
            LabelKoiLastCalibration.Anchor = AnchorStyles.Bottom;
            LabelKoiLastCalibration.AutoSize = true;
            LabelKoiLastCalibration.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelKoiLastCalibration.Location = new Point(78, 8);
            LabelKoiLastCalibration.Name = "LabelKoiLastCalibration";
            LabelKoiLastCalibration.Size = new Size(13, 18);
            LabelKoiLastCalibration.TabIndex = 2;
            LabelKoiLastCalibration.Text = "-";
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel19.ColumnCount = 1;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.Controls.Add(tableLayoutPanel20, 0, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(3, 242);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel19.Size = new Size(563, 61);
            tableLayoutPanel19.TabIndex = 6;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.BackColor = Color.White;
            tableLayoutPanel20.ColumnCount = 8;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel20.Controls.Add(ButtonIletkenlikSpan, 7, 0);
            tableLayoutPanel20.Controls.Add(panel14, 0, 0);
            tableLayoutPanel20.Controls.Add(tableLayoutPanel21, 1, 0);
            tableLayoutPanel20.Controls.Add(ButtonIletkenlikZero, 5, 0);
            tableLayoutPanel20.Controls.Add(panel15, 2, 0);
            tableLayoutPanel20.Controls.Add(panel17, 4, 0);
            tableLayoutPanel20.Controls.Add(tableLayoutPanel22, 3, 0);
            tableLayoutPanel20.Controls.Add(panel18, 6, 0);
            tableLayoutPanel20.Dock = DockStyle.Fill;
            tableLayoutPanel20.Location = new Point(1, 1);
            tableLayoutPanel20.Margin = new Padding(1);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 1;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel20.Size = new Size(561, 59);
            tableLayoutPanel20.TabIndex = 0;
            // 
            // ButtonIletkenlikSpan
            // 
            ButtonIletkenlikSpan.BackColor = Color.FromArgb(0, 131, 200);
            ButtonIletkenlikSpan.Dock = DockStyle.Fill;
            ButtonIletkenlikSpan.FlatAppearance.BorderSize = 0;
            ButtonIletkenlikSpan.ForeColor = Color.White;
            ButtonIletkenlikSpan.Location = new Point(485, 15);
            ButtonIletkenlikSpan.Margin = new Padding(10, 15, 15, 15);
            ButtonIletkenlikSpan.Name = "ButtonIletkenlikSpan";
            ButtonIletkenlikSpan.Size = new Size(61, 29);
            ButtonIletkenlikSpan.TabIndex = 5;
            ButtonIletkenlikSpan.Text = "SPAN";
            ButtonIletkenlikSpan.UseVisualStyleBackColor = false;
            ButtonIletkenlikSpan.Click += ButtonIletkenlikSpan_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Gray;
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 0);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(8, 59);
            panel14.TabIndex = 2;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.Controls.Add(label17, 0, 1);
            tableLayoutPanel21.Controls.Add(label18, 0, 0);
            tableLayoutPanel21.Dock = DockStyle.Fill;
            tableLayoutPanel21.Location = new Point(11, 3);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 2;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.Size = new Size(170, 53);
            tableLayoutPanel21.TabIndex = 2;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 8.25F);
            label17.Location = new Point(22, 26);
            label17.Name = "label17";
            label17.Size = new Size(125, 14);
            label17.TabIndex = 2;
            label17.Text = "Sudaki İletkenlik Seviyesi";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label18.Location = new Point(49, 8);
            label18.Name = "label18";
            label18.Size = new Size(72, 18);
            label18.TabIndex = 2;
            label18.Text = "İletkenlik";
            // 
            // ButtonIletkenlikZero
            // 
            ButtonIletkenlikZero.BackColor = Color.FromArgb(0, 131, 200);
            ButtonIletkenlikZero.Dock = DockStyle.Fill;
            ButtonIletkenlikZero.FlatAppearance.BorderSize = 0;
            ButtonIletkenlikZero.ForeColor = Color.White;
            ButtonIletkenlikZero.Location = new Point(395, 15);
            ButtonIletkenlikZero.Margin = new Padding(15, 15, 10, 15);
            ButtonIletkenlikZero.Name = "ButtonIletkenlikZero";
            ButtonIletkenlikZero.Size = new Size(60, 29);
            ButtonIletkenlikZero.TabIndex = 4;
            ButtonIletkenlikZero.Text = "ZERO";
            ButtonIletkenlikZero.UseVisualStyleBackColor = false;
            ButtonIletkenlikZero.Click += ButtonIletkenlikZero_Click;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.None;
            panel15.BackColor = Color.FromArgb(235, 235, 235);
            panel15.Location = new Point(188, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(1, 53);
            panel15.TabIndex = 2;
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.None;
            panel17.BackColor = Color.FromArgb(235, 235, 235);
            panel17.Location = new Point(374, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(1, 53);
            panel17.TabIndex = 2;
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 1;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel22.Controls.Add(label19, 0, 1);
            tableLayoutPanel22.Controls.Add(LabelIletkenlikLastCalibration, 0, 0);
            tableLayoutPanel22.Dock = DockStyle.Fill;
            tableLayoutPanel22.Location = new Point(197, 3);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 2;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel22.Size = new Size(170, 53);
            tableLayoutPanel22.TabIndex = 3;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 8.25F);
            label19.Location = new Point(28, 26);
            label19.Name = "label19";
            label19.Size = new Size(114, 14);
            label19.TabIndex = 2;
            label19.Text = "Son Kalibrasyon Tarihi";
            // 
            // LabelIletkenlikLastCalibration
            // 
            LabelIletkenlikLastCalibration.Anchor = AnchorStyles.Bottom;
            LabelIletkenlikLastCalibration.AutoSize = true;
            LabelIletkenlikLastCalibration.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelIletkenlikLastCalibration.Location = new Point(78, 8);
            LabelIletkenlikLastCalibration.Name = "LabelIletkenlikLastCalibration";
            LabelIletkenlikLastCalibration.Size = new Size(13, 18);
            LabelIletkenlikLastCalibration.TabIndex = 2;
            LabelIletkenlikLastCalibration.Text = "-";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.None;
            panel18.BackColor = Color.FromArgb(235, 235, 235);
            panel18.Location = new Point(469, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(1, 53);
            panel18.TabIndex = 2;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 175);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel15.Size = new Size(563, 61);
            tableLayoutPanel15.TabIndex = 5;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.BackColor = Color.White;
            tableLayoutPanel16.ColumnCount = 8;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel16.Controls.Add(ButtonPhSpan, 7, 0);
            tableLayoutPanel16.Controls.Add(panel10, 0, 0);
            tableLayoutPanel16.Controls.Add(tableLayoutPanel17, 1, 0);
            tableLayoutPanel16.Controls.Add(ButtonPhZero, 5, 0);
            tableLayoutPanel16.Controls.Add(panel11, 2, 0);
            tableLayoutPanel16.Controls.Add(panel12, 4, 0);
            tableLayoutPanel16.Controls.Add(tableLayoutPanel18, 3, 0);
            tableLayoutPanel16.Controls.Add(panel13, 6, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(1, 1);
            tableLayoutPanel16.Margin = new Padding(1);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(561, 59);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // ButtonPhSpan
            // 
            ButtonPhSpan.BackColor = Color.FromArgb(0, 131, 200);
            ButtonPhSpan.Dock = DockStyle.Fill;
            ButtonPhSpan.FlatAppearance.BorderSize = 0;
            ButtonPhSpan.ForeColor = Color.White;
            ButtonPhSpan.Location = new Point(485, 15);
            ButtonPhSpan.Margin = new Padding(10, 15, 15, 15);
            ButtonPhSpan.Name = "ButtonPhSpan";
            ButtonPhSpan.Size = new Size(61, 29);
            ButtonPhSpan.TabIndex = 5;
            ButtonPhSpan.Text = "SPAN";
            ButtonPhSpan.UseVisualStyleBackColor = false;
            ButtonPhSpan.Click += ButtonPhSpan_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gray;
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(8, 59);
            panel10.TabIndex = 2;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 1;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.Controls.Add(label13, 0, 1);
            tableLayoutPanel17.Controls.Add(label14, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(11, 3);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 2;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.Size = new Size(170, 53);
            tableLayoutPanel17.TabIndex = 2;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 8.25F);
            label13.Location = new Point(36, 26);
            label13.Name = "label13";
            label13.Size = new Size(98, 14);
            label13.TabIndex = 2;
            label13.Text = "Potansiyel Hidrojen";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label14.Location = new Point(71, 8);
            label14.Name = "label14";
            label14.Size = new Size(27, 18);
            label14.TabIndex = 2;
            label14.Text = "Ph";
            // 
            // ButtonPhZero
            // 
            ButtonPhZero.BackColor = Color.FromArgb(0, 131, 200);
            ButtonPhZero.Dock = DockStyle.Fill;
            ButtonPhZero.FlatAppearance.BorderSize = 0;
            ButtonPhZero.ForeColor = Color.White;
            ButtonPhZero.Location = new Point(395, 15);
            ButtonPhZero.Margin = new Padding(15, 15, 10, 15);
            ButtonPhZero.Name = "ButtonPhZero";
            ButtonPhZero.Size = new Size(60, 29);
            ButtonPhZero.TabIndex = 4;
            ButtonPhZero.Text = "ZERO";
            ButtonPhZero.UseVisualStyleBackColor = false;
            ButtonPhZero.Click += ButtonPhZero_Click;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.FromArgb(235, 235, 235);
            panel11.Location = new Point(188, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 50);
            panel11.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.FromArgb(235, 235, 235);
            panel12.Location = new Point(374, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 50);
            panel12.TabIndex = 2;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 1;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.Controls.Add(label15, 0, 1);
            tableLayoutPanel18.Controls.Add(LabelPhLastCalibration, 0, 0);
            tableLayoutPanel18.Dock = DockStyle.Fill;
            tableLayoutPanel18.Location = new Point(197, 3);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 2;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.Size = new Size(170, 53);
            tableLayoutPanel18.TabIndex = 3;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 8.25F);
            label15.Location = new Point(28, 26);
            label15.Name = "label15";
            label15.Size = new Size(114, 14);
            label15.TabIndex = 2;
            label15.Text = "Son Kalibrasyon Tarihi";
            // 
            // LabelPhLastCalibration
            // 
            LabelPhLastCalibration.Anchor = AnchorStyles.Bottom;
            LabelPhLastCalibration.AutoSize = true;
            LabelPhLastCalibration.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelPhLastCalibration.Location = new Point(78, 8);
            LabelPhLastCalibration.Name = "LabelPhLastCalibration";
            LabelPhLastCalibration.Size = new Size(13, 18);
            LabelPhLastCalibration.TabIndex = 2;
            LabelPhLastCalibration.Text = "-";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.None;
            panel13.BackColor = Color.FromArgb(235, 235, 235);
            panel13.Location = new Point(469, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1, 50);
            panel13.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 41);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(563, 61);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Controls.Add(ButtonAkmZero, 5, 0);
            tableLayoutPanel4.Controls.Add(panel2, 2, 0);
            tableLayoutPanel4.Controls.Add(panel3, 4, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(561, 59);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 59);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label1, 0, 1);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(11, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(170, 53);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8.25F);
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 14);
            label1.TabIndex = 2;
            label1.Text = "Askıda Katı Madde";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.Location = new Point(66, 8);
            label2.Name = "label2";
            label2.Size = new Size(37, 18);
            label2.TabIndex = 2;
            label2.Text = "Akm";
            // 
            // ButtonAkmZero
            // 
            ButtonAkmZero.BackColor = Color.FromArgb(0, 131, 200);
            ButtonAkmZero.Dock = DockStyle.Fill;
            ButtonAkmZero.FlatAppearance.BorderSize = 0;
            ButtonAkmZero.ForeColor = Color.White;
            ButtonAkmZero.Location = new Point(395, 15);
            ButtonAkmZero.Margin = new Padding(15);
            ButtonAkmZero.Name = "ButtonAkmZero";
            ButtonAkmZero.Size = new Size(151, 29);
            ButtonAkmZero.TabIndex = 4;
            ButtonAkmZero.Text = "ZERO";
            ButtonAkmZero.UseVisualStyleBackColor = false;
            //ButtonAkmZero.Click += ButtonAkmZero_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(188, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 50);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Location = new Point(374, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 50);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label3, 0, 1);
            tableLayoutPanel6.Controls.Add(LabelAkmLastCalibration, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(197, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(170, 53);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 8.25F);
            label3.Location = new Point(28, 26);
            label3.Name = "label3";
            label3.Size = new Size(114, 14);
            label3.TabIndex = 2;
            label3.Text = "Son Kalibrasyon Tarihi";
            // 
            // LabelAkmLastCalibration
            // 
            LabelAkmLastCalibration.Anchor = AnchorStyles.Bottom;
            LabelAkmLastCalibration.AutoSize = true;
            LabelAkmLastCalibration.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelAkmLastCalibration.Location = new Point(78, 8);
            LabelAkmLastCalibration.Name = "LabelAkmLastCalibration";
            LabelAkmLastCalibration.Size = new Size(13, 18);
            LabelAkmLastCalibration.TabIndex = 2;
            LabelAkmLastCalibration.Text = "-";
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(3, 3);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(563, 32);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Kalibrasyon Parametreleri ";
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 1;
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel27.Controls.Add(TitleBarControlActiveCalibration, 0, 0);
            tableLayoutPanel27.Controls.Add(CalibrationStatusBarZero, 0, 1);
            tableLayoutPanel27.Controls.Add(CalibrationStatusBarSpan, 0, 2);
            tableLayoutPanel27.Dock = DockStyle.Fill;
            tableLayoutPanel27.Location = new Point(593, 8);
            tableLayoutPanel27.Margin = new Padding(8);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.RowCount = 4;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel27.Size = new Size(569, 306);
            tableLayoutPanel27.TabIndex = 1;
            // 
            // TitleBarControlActiveCalibration
            // 
            TitleBarControlActiveCalibration.BackColor = Color.FromArgb(235, 235, 235);
            TitleBarControlActiveCalibration.Dock = DockStyle.Fill;
            TitleBarControlActiveCalibration.Location = new Point(3, 3);
            TitleBarControlActiveCalibration.Name = "TitleBarControlActiveCalibration";
            TitleBarControlActiveCalibration.Padding = new Padding(1);
            TitleBarControlActiveCalibration.Size = new Size(563, 32);
            TitleBarControlActiveCalibration.TabIndex = 0;
            TitleBarControlActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
            // 
            // CalibrationStatusBarZero
            // 
            CalibrationStatusBarZero.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationStatusBarZero.Dock = DockStyle.Fill;
            CalibrationStatusBarZero.Location = new Point(3, 41);
            CalibrationStatusBarZero.Name = "CalibrationStatusBarZero";
            CalibrationStatusBarZero.Padding = new Padding(1);
            CalibrationStatusBarZero.Size = new Size(563, 44);
            CalibrationStatusBarZero.TabIndex = 1;
            CalibrationStatusBarZero.ZeroDiff = "-";
            CalibrationStatusBarZero.ZeroMeas = "-";
            CalibrationStatusBarZero.ZeroRef = "-";
            CalibrationStatusBarZero.ZeroStd = "-";
            // 
            // CalibrationStatusBarSpan
            // 
            CalibrationStatusBarSpan.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationStatusBarSpan.Dock = DockStyle.Fill;
            CalibrationStatusBarSpan.Location = new Point(3, 91);
            CalibrationStatusBarSpan.Name = "CalibrationStatusBarSpan";
            CalibrationStatusBarSpan.Padding = new Padding(1);
            CalibrationStatusBarSpan.Size = new Size(563, 44);
            CalibrationStatusBarSpan.SpanDiff = "-";
            CalibrationStatusBarSpan.SpanMeas = "-";
            CalibrationStatusBarSpan.SpanRef = "-";
            CalibrationStatusBarSpan.SpanStd = "-";
            CalibrationStatusBarSpan.TabIndex = 2;
            // 
            // tableLayoutPanel28
            // 
            tableLayoutPanel28.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel28, 2);
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel28.Controls.Add(TitleBarControlTimeRemain, 1, 0);
            tableLayoutPanel28.Controls.Add(titleBarControl3, 0, 0);
            tableLayoutPanel28.Dock = DockStyle.Fill;
            tableLayoutPanel28.Location = new Point(8, 322);
            tableLayoutPanel28.Margin = new Padding(8, 0, 8, 0);
            tableLayoutPanel28.Name = "tableLayoutPanel28";
            tableLayoutPanel28.RowCount = 1;
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.Size = new Size(1154, 32);
            tableLayoutPanel28.TabIndex = 2;
            // 
            // TitleBarControlTimeRemain
            // 
            TitleBarControlTimeRemain.BackColor = Color.FromArgb(235, 235, 235);
            TitleBarControlTimeRemain.Dock = DockStyle.Fill;
            TitleBarControlTimeRemain.Location = new Point(980, 0);
            TitleBarControlTimeRemain.Margin = new Padding(8, 0, 0, 0);
            TitleBarControlTimeRemain.Name = "TitleBarControlTimeRemain";
            TitleBarControlTimeRemain.Padding = new Padding(1);
            TitleBarControlTimeRemain.Size = new Size(174, 32);
            TitleBarControlTimeRemain.TabIndex = 1;
            TitleBarControlTimeRemain.TitleBarText = "Kalan Süre: -";
            // 
            // titleBarControl3
            // 
            titleBarControl3.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl3.Dock = DockStyle.Fill;
            titleBarControl3.Location = new Point(0, 0);
            titleBarControl3.Margin = new Padding(0, 0, 8, 0);
            titleBarControl3.Name = "titleBarControl3";
            titleBarControl3.Padding = new Padding(1);
            titleBarControl3.Size = new Size(964, 32);
            titleBarControl3.TabIndex = 0;
            titleBarControl3.TitleBarText = "Kalibrasyon Simülasyonu";
            // 
            // tableLayoutPanel29
            // 
            tableLayoutPanel29.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel29.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel29, 2);
            tableLayoutPanel29.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel29.Controls.Add(ChartCalibration, 0, 0);
            tableLayoutPanel29.Dock = DockStyle.Fill;
            tableLayoutPanel29.Location = new Point(8, 362);
            tableLayoutPanel29.Margin = new Padding(8);
            tableLayoutPanel29.Name = "tableLayoutPanel29";
            tableLayoutPanel29.RowCount = 1;
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel29.Size = new Size(1154, 307);
            tableLayoutPanel29.TabIndex = 55;
            // 
            // ChartCalibration
            // 
            chartArea1.Area3DStyle.LightStyle = LightStyle.Realistic;
            chartArea1.AxisX.InterlacedColor = Color.White;
            chartArea1.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineWidth = 3;
            chartArea1.AxisX.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleBreakStyle.LineDashStyle = ChartDashStyle.DashDot;
            chartArea1.AxisX.ScaleBreakStyle.LineWidth = 10;
            chartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.IntervalOffsetType = DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.IntervalType = DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = BreakLineStyle.Wave;
            chartArea1.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 5D;
            chartArea1.AxisY2.Maximum = 10D;
            chartArea1.AxisY2.Minimum = 5D;
            chartArea1.AxisY2.ScaleBreakStyle.BreakLineStyle = BreakLineStyle.Wave;
            chartArea1.AxisY2.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY2.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisY2.ScaleBreakStyle.StartFromZero = StartFromZero.Yes;
            chartArea1.BackColor = Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 88.59933F;
            chartArea1.InnerPlotPosition.Width = 94.71543F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.InnerPlotPosition.Y = 2F;
            chartArea1.Name = "ChartArea1";
            ChartCalibration.ChartAreas.Add(chartArea1);
            ChartCalibration.Dock = DockStyle.Fill;
            legend1.BackColor = Color.WhiteSmoke;
            legend1.ItemColumnSpacing = 0;
            legend1.Name = "Legend1";
            ChartCalibration.Legends.Add(legend1);
            ChartCalibration.Location = new Point(1, 1);
            ChartCalibration.Margin = new Padding(1);
            ChartCalibration.Name = "ChartCalibration";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Color = Color.Lime;
            series1.CustomProperties = "LabelStyle=Center";
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.Name = "Kalibrasyon Değeri";
            series1.XValueType = ChartValueType.Time;
            series1.YValueType = ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Spline;
            series2.Color = Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Referans Değeri";
            series2.XValueType = ChartValueType.Time;
            series2.YValueType = ChartValueType.Double;
            ChartCalibration.Series.Add(series1);
            ChartCalibration.Series.Add(series2);
            ChartCalibration.Size = new Size(1152, 305);
            ChartCalibration.TabIndex = 54;
            title1.Name = "Kalibrasyon Grafiği";
            ChartCalibration.Titles.Add(title1);
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.White;
            tableLayoutPanel8.ColumnCount = 6;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(panel4, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel8.Controls.Add(button2, 5, 0);
            tableLayoutPanel8.Controls.Add(panel5, 2, 0);
            tableLayoutPanel8.Controls.Add(panel6, 4, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 3, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(1, 1);
            tableLayoutPanel8.Margin = new Padding(1);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(198, 98);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 98);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label5, 0, 1);
            tableLayoutPanel9.Controls.Add(label6, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(11, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(50, 92);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 8.25F);
            label5.Location = new Point(3, 46);
            label5.Name = "label5";
            label5.Size = new Size(43, 42);
            label5.TabIndex = 2;
            label5.Text = "Askıda Katı Madde";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label6.Location = new Point(4, 28);
            label6.Name = "label6";
            label6.Size = new Size(41, 18);
            label6.TabIndex = 2;
            label6.Text = "AKM";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 131, 200);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(155, 15);
            button2.Margin = new Padding(15);
            button2.Name = "button2";
            button2.Size = new Size(28, 68);
            button2.TabIndex = 4;
            button2.Text = "ZERO";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(235, 235, 235);
            panel5.Location = new Point(68, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 57);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(235, 235, 235);
            panel6.Location = new Point(134, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 57);
            panel6.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label7, 0, 1);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(77, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(50, 92);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 8.25F);
            label7.Location = new Point(5, 46);
            label7.Name = "label7";
            label7.Size = new Size(40, 46);
            label7.TabIndex = 2;
            label7.Text = "Son Kalibrasyon Tarihi";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label8.Location = new Point(18, 28);
            label8.Name = "label8";
            label8.Size = new Size(13, 18);
            label8.TabIndex = 2;
            label8.Text = "-";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(200, 100);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = Color.White;
            tableLayoutPanel12.ColumnCount = 6;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel12.Controls.Add(panel7, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel12.Controls.Add(button3, 5, 0);
            tableLayoutPanel12.Controls.Add(panel8, 2, 0);
            tableLayoutPanel12.Controls.Add(panel9, 4, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel14, 3, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(1, 1);
            tableLayoutPanel12.Margin = new Padding(1);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(198, 98);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(8, 98);
            panel7.TabIndex = 2;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label9, 0, 1);
            tableLayoutPanel13.Controls.Add(label10, 0, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(11, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(1, 92);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 8.25F);
            label9.Location = new Point(3, 46);
            label9.Name = "label9";
            label9.Size = new Size(1, 14);
            label9.TabIndex = 2;
            label9.Text = "Askıda Katı Madde";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label10.Location = new Point(3, 28);
            label10.Name = "label10";
            label10.Size = new Size(1, 18);
            label10.TabIndex = 2;
            label10.Text = "AKM";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 131, 200);
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(33, 15);
            button3.Margin = new Padding(15);
            button3.Name = "button3";
            button3.Size = new Size(150, 68);
            button3.TabIndex = 4;
            button3.Text = "ZERO";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.FromArgb(235, 235, 235);
            panel8.Location = new Point(7, 20);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 57);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.FromArgb(235, 235, 235);
            panel9.Location = new Point(12, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 57);
            panel9.TabIndex = 2;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label11, 0, 1);
            tableLayoutPanel14.Controls.Add(label12, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(16, 3);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(1, 92);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 8.25F);
            label11.Location = new Point(3, 46);
            label11.Name = "label11";
            label11.Size = new Size(1, 14);
            label11.TabIndex = 2;
            label11.Text = "Son Kalibrasyon Tarihi";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label12.Location = new Point(3, 28);
            label12.Name = "label12";
            label12.Size = new Size(1, 18);
            label12.TabIndex = 2;
            label12.Text = "-";
            // 
            // CalibrationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "CalibrationPage";
            Size = new Size(1170, 677);
            Load += CalibrationPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel24.ResumeLayout(false);
            tableLayoutPanel25.ResumeLayout(false);
            tableLayoutPanel25.PerformLayout();
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel21.PerformLayout();
            tableLayoutPanel22.ResumeLayout(false);
            tableLayoutPanel22.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            tableLayoutPanel18.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel28.ResumeLayout(false);
            tableLayoutPanel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartCalibration).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TitleBarControl titleBarControl1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Button ButtonAkmZero;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private Label LabelAkmLastCalibration;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Button button2;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel23;
        private TableLayoutPanel tableLayoutPanel24;
        private Panel panel16;
        private TableLayoutPanel tableLayoutPanel25;
        private Label label21;
        private Label label22;
        private System.Windows.Forms.Button ButtonKoiZero;
        private Panel panel19;
        private Panel panel20;
        private TableLayoutPanel tableLayoutPanel26;
        private Label label23;
        private Label LabelKoiLastCalibration;
        private TableLayoutPanel tableLayoutPanel19;
        private TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Button ButtonIletkenlikSpan;
        private Panel panel14;
        private TableLayoutPanel tableLayoutPanel21;
        private Label label17;
        private Label label18;
        private System.Windows.Forms.Button ButtonIletkenlikZero;
        private Panel panel15;
        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel22;
        private Label label19;
        private Label LabelIletkenlikLastCalibration;
        private Panel panel18;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button ButtonPhSpan;
        private Panel panel10;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label13;
        private Label label14;
        private System.Windows.Forms.Button ButtonPhZero;
        private Panel panel11;
        private Panel panel12;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label15;
        private Label LabelPhLastCalibration;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label9;
        private Label label10;
        private System.Windows.Forms.Button button3;
        private Panel panel8;
        private Panel panel9;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label11;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel27;
        private TitleBarControl TitleBarControlActiveCalibration;
        private CalibrationStatusBarZeroControl CalibrationStatusBarZero;
        private CalibrationStatusBarSpanControl CalibrationStatusBarSpan;
        private TableLayoutPanel tableLayoutPanel28;
        private TitleBarControl titleBarControl3;
        private TitleBarControl TitleBarControlTimeRemain;
        private Chart ChartCalibration;
        private TableLayoutPanel tableLayoutPanel29;
    }
}
