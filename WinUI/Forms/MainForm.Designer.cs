namespace WinUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            SideBarTableLayoutPanel = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            SideBarTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 8.25F);
            button1.ForeColor = Color.DimGray;
            button1.Image = Properties.Resources.home_24px;
            button1.Location = new Point(8, 8);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(74, 68);
            button1.TabIndex = 1;
            button1.Text = "Anasayfa";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // SideBarTableLayoutPanel
            // 
            SideBarTableLayoutPanel.ColumnCount = 1;
            SideBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SideBarTableLayoutPanel.Controls.Add(button1, 0, 0);
            SideBarTableLayoutPanel.Controls.Add(button2, 0, 1);
            SideBarTableLayoutPanel.Controls.Add(button3, 0, 2);
            SideBarTableLayoutPanel.Controls.Add(button4, 0, 3);
            SideBarTableLayoutPanel.Controls.Add(button5, 0, 4);
            SideBarTableLayoutPanel.Controls.Add(button7, 0, 7);
            SideBarTableLayoutPanel.Dock = DockStyle.Left;
            SideBarTableLayoutPanel.Location = new Point(0, 0);
            SideBarTableLayoutPanel.Name = "SideBarTableLayoutPanel";
            SideBarTableLayoutPanel.RowCount = 8;
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.Size = new Size(90, 681);
            SideBarTableLayoutPanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 8.25F);
            button2.ForeColor = Color.DimGray;
            button2.Image = Properties.Resources.monitor_24px;
            button2.Location = new Point(8, 92);
            button2.Margin = new Padding(8);
            button2.Name = "button2";
            button2.Size = new Size(74, 68);
            button2.TabIndex = 1;
            button2.Text = "Simülasyon";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 8.25F);
            button3.ForeColor = Color.DimGray;
            button3.Image = Properties.Resources.azimuth_24px;
            button3.Location = new Point(8, 176);
            button3.Margin = new Padding(8);
            button3.Name = "button3";
            button3.Size = new Size(74, 68);
            button3.TabIndex = 1;
            button3.Text = "Kalibrasyon";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 8.25F);
            button4.ForeColor = Color.DimGray;
            button4.Image = Properties.Resources.alarm_24px;
            button4.Location = new Point(8, 260);
            button4.Margin = new Padding(8);
            button4.Name = "button4";
            button4.Size = new Size(74, 68);
            button4.TabIndex = 1;
            button4.Text = "Mail";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 8.25F);
            button5.ForeColor = Color.DimGray;
            button5.Image = Properties.Resources.save_24px;
            button5.Location = new Point(8, 344);
            button5.Margin = new Padding(8);
            button5.Name = "button5";
            button5.Size = new Size(74, 68);
            button5.TabIndex = 1;
            button5.Text = "Raporlama";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Calibri", 8.25F);
            button7.ForeColor = Color.DimGray;
            button7.Image = Properties.Resources.settings_24px;
            button7.Location = new Point(8, 605);
            button7.Margin = new Padding(8);
            button7.Name = "button7";
            button7.Size = new Size(74, 68);
            button7.TabIndex = 1;
            button7.Text = "Ayarlar";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(SideBarTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İSKİ Marbin Yönetim Sistemi";
            SideBarTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TableLayoutPanel SideBarTableLayoutPanel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
    }
}