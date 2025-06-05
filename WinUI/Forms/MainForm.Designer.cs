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
            HomePageButton = new Button();
            SideBarTableLayoutPanel = new TableLayoutPanel();
            SideBarTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // 
            // 
            // SideBarTableLayoutPanel
            // 
            SideBarTableLayoutPanel.BackColor = Color.White;
            SideBarTableLayoutPanel.ColumnCount = 1;
            SideBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(MainContentPanel);
            Controls.Add(SideBarTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İSKİ Marbin Yönetim Sistemi";
            Load += MainForm_Load;
            SideBarTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SideBarTableLayoutPanel;
    }
}