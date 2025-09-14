
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
            mainLayoutPanel = new TableLayoutPanel();
            titleBarControl = new WinUI.Controls.IBKS.TitleBarControl();
            contentPanel = new Panel();
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            alarmsTableLayoutPanel = new TableLayoutPanel();
            contentTableLayoutPanel = new TableLayoutPanel();
            usersHeaderTableLayoutPanel = new TableLayoutPanel();
            usersLabel = new Label();
            newUserButton = new Button();
            usersTableLayoutPanel = new TableLayoutPanel();
            alarmsDataGridView = new DataGridView();
            usersDataGridView = new DataGridView();
            alarmsHeaderTableLayoutPanel = new TableLayoutPanel();
            alarmsLabel = new Label();
            mainLayoutPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            alarmsTableLayoutPanel.SuspendLayout();
            contentTableLayoutPanel.SuspendLayout();
            usersHeaderTableLayoutPanel.SuspendLayout();
            usersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            alarmsHeaderTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // mainLayoutPanel
            //
            mainLayoutPanel.ColumnCount = 2;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayoutPanel.Controls.Add(titleBarControl, 0, 0);
            mainLayoutPanel.Controls.Add(contentPanel, 0, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(8);
            mainLayoutPanel.RowCount = 3;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.Size = new Size(1170, 677);
            mainLayoutPanel.TabIndex = 2;
            // 
            // titleBarControl
            //
            titleBarControl.BackColor = Color.FromArgb(235, 235, 235);
            mainLayoutPanel.SetColumnSpan(titleBarControl, 2);
            titleBarControl.Dock = DockStyle.Fill;
            titleBarControl.Location = new Point(11, 11);
            titleBarControl.Name = "titleBarControl";
            titleBarControl.Padding = new Padding(1);
            titleBarControl.Size = new Size(1148, 32);
            titleBarControl.TabIndex = 0;
            titleBarControl.TitleBarText = "Mail Alarmları";
            //
            // contentPanel
            //
            mainLayoutPanel.SetColumnSpan(contentPanel, 2);
            contentPanel.Controls.Add(contentTableLayoutPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(8, 46);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(60, 30, 0, 60);
            mainLayoutPanel.SetRowSpan(contentPanel, 2);
            contentPanel.Size = new Size(1154, 623);
            contentPanel.TabIndex = 1;
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
            alarmsTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            alarmsTableLayoutPanel.ColumnCount = 1;
            alarmsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            alarmsTableLayoutPanel.Controls.Add(alarmsDataGridView, 0, 0);
            alarmsTableLayoutPanel.Dock = DockStyle.Fill;
            alarmsTableLayoutPanel.Location = new Point(547, 40);
            alarmsTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            alarmsTableLayoutPanel.Name = "alarmsTableLayoutPanel";
            alarmsTableLayoutPanel.RowCount = 1;
            alarmsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            alarmsTableLayoutPanel.Size = new Size(542, 493);
            alarmsTableLayoutPanel.TabIndex = 6;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            contentTableLayoutPanel.ColumnCount = 2;
            contentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contentTableLayoutPanel.Controls.Add(alarmsHeaderTableLayoutPanel, 1, 0);
            contentTableLayoutPanel.Controls.Add(alarmsTableLayoutPanel, 1, 1);
            contentTableLayoutPanel.Controls.Add(usersHeaderTableLayoutPanel, 0, 0);
            contentTableLayoutPanel.Controls.Add(usersTableLayoutPanel, 0, 1);
            contentTableLayoutPanel.Dock = DockStyle.Fill;
            contentTableLayoutPanel.Location = new Point(60, 30);
            contentTableLayoutPanel.Name = "contentTableLayoutPanel";
            contentTableLayoutPanel.RowCount = 2;
            contentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            contentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            contentTableLayoutPanel.Size = new Size(1094, 533);
            contentTableLayoutPanel.TabIndex = 3;
            // 
            // ApiSettingsHeaderTableLayoutPanel
            // 
            usersHeaderTableLayoutPanel.ColumnCount = 2;
            usersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.Controls.Add(usersLabel, 0, 0);
            usersHeaderTableLayoutPanel.Controls.Add(newUserButton, 1, 0);
            usersHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            usersHeaderTableLayoutPanel.Location = new Point(0, 0);
            usersHeaderTableLayoutPanel.Margin = new Padding(0);
            usersHeaderTableLayoutPanel.Name = "usersHeaderTableLayoutPanel";
            usersHeaderTableLayoutPanel.RowCount = 1;
            usersHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.Size = new Size(547, 40);
            usersHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // ApiSettingsLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usersLabel.ForeColor = Color.FromArgb(64, 64, 64);
            usersLabel.Location = new Point(3, 0);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(114, 22);
            usersLabel.TabIndex = 0;
            usersLabel.Text = "Kullanıcılar";
            // 
            // SaveApiSettingsButton
            // 
            newUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newUserButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserButton.Location = new Point(405, 3);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(139, 32);
            newUserButton.TabIndex = 2;
            newUserButton.Text = "Yeni Kullanıcı";
            newUserButton.UseVisualStyleBackColor = true;
            // 
            // StationInfoBgTableLayoutPanel
            // 
            usersTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            usersTableLayoutPanel.ColumnCount = 1;
            usersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersTableLayoutPanel.Controls.Add(usersDataGridView, 0, 0);
            usersTableLayoutPanel.Dock = DockStyle.Fill;
            usersTableLayoutPanel.Location = new Point(0, 40);
            usersTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            usersTableLayoutPanel.Name = "usersTableLayoutPanel";
            usersTableLayoutPanel.RowCount = 1;
            usersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            usersTableLayoutPanel.Size = new Size(542, 493);
            usersTableLayoutPanel.TabIndex = 5;
            // 
            // dataGridView2
            // 
            alarmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alarmsDataGridView.Dock = DockStyle.Fill;
            alarmsDataGridView.Location = new Point(3, 3);
            alarmsDataGridView.Name = "alarmsDataGridView";
            alarmsDataGridView.Size = new Size(536, 487);
            alarmsDataGridView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Dock = DockStyle.Fill;
            usersDataGridView.Location = new Point(3, 3);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.Size = new Size(536, 487);
            usersDataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            alarmsHeaderTableLayoutPanel.ColumnCount = 2;
            alarmsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            alarmsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            alarmsHeaderTableLayoutPanel.Controls.Add(alarmsLabel, 0, 0);
            alarmsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            alarmsHeaderTableLayoutPanel.Location = new Point(547, 0);
            alarmsHeaderTableLayoutPanel.Margin = new Padding(0);
            alarmsHeaderTableLayoutPanel.Name = "alarmsHeaderTableLayoutPanel";
            alarmsHeaderTableLayoutPanel.RowCount = 1;
            alarmsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            alarmsHeaderTableLayoutPanel.Size = new Size(547, 40);
            alarmsHeaderTableLayoutPanel.TabIndex = 7;
            // 
            // label1
            // 
            alarmsLabel.AutoSize = true;
            alarmsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            alarmsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            alarmsLabel.Location = new Point(3, 0);
            alarmsLabel.Name = "alarmsLabel";
            alarmsLabel.Size = new Size(88, 22);
            alarmsLabel.TabIndex = 0;
            alarmsLabel.Text = "Alarmlar";
            // 
            // MailPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(mainLayoutPanel);
            Name = "MailPage";
            Size = new Size(1170, 677);
            SizeChanged += MailPage_SizeChanged;
            mainLayoutPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            alarmsTableLayoutPanel.ResumeLayout(false);
            contentTableLayoutPanel.ResumeLayout(false);
            usersHeaderTableLayoutPanel.ResumeLayout(false);
            usersHeaderTableLayoutPanel.PerformLayout();
            usersTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            alarmsHeaderTableLayoutPanel.ResumeLayout(false);
            alarmsHeaderTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void MailPage_SizeChanged(object sender, EventArgs e)
        {
        }

        private void ButtonMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonMailUsers_Click(object sender, EventArgs e)
        {
        }

        private void ButtonEditMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private Controls.IBKS.TitleBarControl titleBarControl;
        private Panel contentPanel;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private TableLayoutPanel contentTableLayoutPanel;
        private TableLayoutPanel alarmsTableLayoutPanel;
        private TableLayoutPanel usersHeaderTableLayoutPanel;
        private Label usersLabel;
        private Button newUserButton;
        private TableLayoutPanel usersTableLayoutPanel;
        private DataGridView alarmsDataGridView;
        private TableLayoutPanel alarmsHeaderTableLayoutPanel;
        private Label alarmsLabel;
        private DataGridView usersDataGridView;
    }
}
