
namespace WinUI.Pages
{
    partial class MailPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new WinUI.Controls.IBKS.TitleBarControl();
            PanelContent = new Panel();
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            ApiTestBgTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsLabel = new Label();
            SaveApiSettingsButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            PanelContent.SuspendLayout();
            ApiTestBgTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            ApiSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(PanelContent, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(titleBarControl1, 2);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(11, 11);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Mail Alarmları";
            // 
            // PanelContent
            // 
            tableLayoutPanel1.SetColumnSpan(PanelContent, 2);
            PanelContent.Controls.Add(StationSettingsBgTableLayoutPanel);
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(8, 46);
            PanelContent.Margin = new Padding(0);
            PanelContent.Name = "PanelContent";
            PanelContent.Padding = new Padding(60, 30, 0, 60);
            tableLayoutPanel1.SetRowSpan(PanelContent, 2);
            PanelContent.Size = new Size(1154, 623);
            PanelContent.TabIndex = 1;
            // 
            // nameColumn
            // 
            nameColumn.Name = "nameColumn";
            // 
            // valueColumn
            // 
            valueColumn.Name = "valueColumn";
            // 
            // ApiTestBgTableLayoutPanel
            // 
            ApiTestBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            ApiTestBgTableLayoutPanel.ColumnCount = 1;
            ApiTestBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Controls.Add(dataGridView2, 0, 0);
            ApiTestBgTableLayoutPanel.Dock = DockStyle.Fill;
            ApiTestBgTableLayoutPanel.Location = new Point(547, 40);
            ApiTestBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            ApiTestBgTableLayoutPanel.Name = "ApiTestBgTableLayoutPanel";
            ApiTestBgTableLayoutPanel.RowCount = 1;
            ApiTestBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Size = new Size(542, 493);
            ApiTestBgTableLayoutPanel.TabIndex = 6;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiTestBgTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiSettingsHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(60, 30);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // ApiSettingsHeaderTableLayoutPanel
            // 
            ApiSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Controls.Add(ApiSettingsLabel, 0, 0);
            ApiSettingsHeaderTableLayoutPanel.Controls.Add(SaveApiSettingsButton, 1, 0);
            ApiSettingsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            ApiSettingsHeaderTableLayoutPanel.Location = new Point(0, 0);
            ApiSettingsHeaderTableLayoutPanel.Margin = new Padding(0);
            ApiSettingsHeaderTableLayoutPanel.Name = "ApiSettingsHeaderTableLayoutPanel";
            ApiSettingsHeaderTableLayoutPanel.RowCount = 1;
            ApiSettingsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Size = new Size(547, 40);
            ApiSettingsHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // ApiSettingsLabel
            // 
            ApiSettingsLabel.AutoSize = true;
            ApiSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiSettingsLabel.Location = new Point(3, 0);
            ApiSettingsLabel.Name = "ApiSettingsLabel";
            ApiSettingsLabel.Size = new Size(114, 22);
            ApiSettingsLabel.TabIndex = 0;
            ApiSettingsLabel.Text = "Kullanıcılar";
            // 
            // SaveApiSettingsButton
            // 
            SaveApiSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveApiSettingsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveApiSettingsButton.Location = new Point(405, 3);
            SaveApiSettingsButton.Name = "SaveApiSettingsButton";
            SaveApiSettingsButton.Size = new Size(139, 32);
            SaveApiSettingsButton.TabIndex = 2;
            SaveApiSettingsButton.Text = "Yeni Kullanıcı";
            SaveApiSettingsButton.UseVisualStyleBackColor = true;
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(dataGridView1, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 40);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(542, 493);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(536, 487);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 487);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(547, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(547, 40);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Alarmlar";
            // 
            // MailPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "MailPage";
            Size = new Size(1170, 677);
            SizeChanged += MailPage_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            PanelContent.ResumeLayout(false);
            ApiTestBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private void MailPage_SizeChanged(object sender, EventArgs e)
        {
        }

        private void ButtonMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonEditMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.IBKS.TitleBarControl titleBarControl1;
        private Panel PanelContent;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel ApiTestBgTableLayoutPanel;
        private TableLayoutPanel ApiSettingsHeaderTableLayoutPanel;
        private Label ApiSettingsLabel;
        private Button SaveApiSettingsButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
