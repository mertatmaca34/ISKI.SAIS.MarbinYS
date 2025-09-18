namespace WinUI.Controls.IBKS
{
    partial class DigitalSensorBar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutContent = new TableLayoutPanel();
            tableLayoutSystemState = new TableLayoutPanel();
            LabelSystemStateTitle = new Label();
            LabelSystemStateDescription = new Label();
            PanelState = new Panel();
            Splitter2 = new Panel();
            Splitter1 = new Panel();
            tableLayoutChannel = new TableLayoutPanel();
            LabelChannelName = new Label();
            LabelChannelDescription = new Label();
            tableLayoutDataState = new TableLayoutPanel();
            LabelDataStateTitle = new Label();
            LabelDataStateDescription = new Label();
            tableLayoutMain.SuspendLayout();
            tableLayoutContent.SuspendLayout();
            tableLayoutSystemState.SuspendLayout();
            tableLayoutChannel.SuspendLayout();
            tableLayoutDataState.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutContent, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(1);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(579, 48);
            tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutContent
            // 
            tableLayoutContent.BackColor = Color.White;
            tableLayoutContent.ColumnCount = 6;
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333F));
            tableLayoutContent.Controls.Add(tableLayoutSystemState, 3, 0);
            tableLayoutContent.Controls.Add(PanelState, 0, 0);
            tableLayoutContent.Controls.Add(Splitter2, 4, 0);
            tableLayoutContent.Controls.Add(Splitter1, 2, 0);
            tableLayoutContent.Controls.Add(tableLayoutChannel, 1, 0);
            tableLayoutContent.Controls.Add(tableLayoutDataState, 5, 0);
            tableLayoutContent.Dock = DockStyle.Fill;
            tableLayoutContent.Location = new Point(1, 1);
            tableLayoutContent.Margin = new Padding(1);
            tableLayoutContent.Name = "tableLayoutContent";
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutContent.Size = new Size(577, 46);
            tableLayoutContent.TabIndex = 0;
            // 
            // tableLayoutSystemState
            // 
            tableLayoutSystemState.ColumnCount = 1;
            tableLayoutSystemState.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutSystemState.Controls.Add(LabelSystemStateTitle, 0, 0);
            tableLayoutSystemState.Controls.Add(LabelSystemStateDescription, 0, 1);
            tableLayoutSystemState.Dock = DockStyle.Fill;
            tableLayoutSystemState.Location = new Point(203, 3);
            tableLayoutSystemState.Name = "tableLayoutSystemState";
            tableLayoutSystemState.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutSystemState.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutSystemState.Size = new Size(176, 40);
            tableLayoutSystemState.TabIndex = 0;
            // 
            // LabelSystemStateTitle
            // 
            LabelSystemStateTitle.Anchor = AnchorStyles.Bottom;
            LabelSystemStateTitle.AutoSize = true;
            LabelSystemStateTitle.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LabelSystemStateTitle.Location = new Point(49, 6);
            LabelSystemStateTitle.Name = "LabelSystemStateTitle";
            LabelSystemStateTitle.Size = new Size(77, 14);
            LabelSystemStateTitle.TabIndex = 0;
            LabelSystemStateTitle.Text = "PLC DURUMU";
            // 
            // LabelSystemStateDescription
            // 
            LabelSystemStateDescription.Anchor = AnchorStyles.Top;
            LabelSystemStateDescription.AutoSize = true;
            LabelSystemStateDescription.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelSystemStateDescription.Location = new Point(81, 20);
            LabelSystemStateDescription.Name = "LabelSystemStateDescription";
            LabelSystemStateDescription.Size = new Size(13, 18);
            LabelSystemStateDescription.TabIndex = 1;
            LabelSystemStateDescription.Text = "-";
            // 
            // PanelState
            // 
            PanelState.BackColor = Color.Gray;
            PanelState.Dock = DockStyle.Fill;
            PanelState.Location = new Point(0, 0);
            PanelState.Margin = new Padding(0);
            PanelState.Name = "PanelState";
            PanelState.Size = new Size(8, 46);
            PanelState.TabIndex = 1;
            // 
            // Splitter2
            // 
            Splitter2.Anchor = AnchorStyles.None;
            Splitter2.BackColor = Color.FromArgb(235, 235, 235);
            Splitter2.Location = new Point(386, 5);
            Splitter2.Name = "Splitter2";
            Splitter2.Size = new Size(1, 36);
            Splitter2.TabIndex = 2;
            // 
            // Splitter1
            // 
            Splitter1.Anchor = AnchorStyles.None;
            Splitter1.BackColor = Color.FromArgb(235, 235, 235);
            Splitter1.Location = new Point(194, 5);
            Splitter1.Name = "Splitter1";
            Splitter1.Size = new Size(1, 36);
            Splitter1.TabIndex = 3;
            // 
            // tableLayoutChannel
            // 
            tableLayoutChannel.ColumnCount = 1;
            tableLayoutChannel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutChannel.Controls.Add(LabelChannelName, 0, 0);
            tableLayoutChannel.Controls.Add(LabelChannelDescription, 0, 1);
            tableLayoutChannel.Dock = DockStyle.Fill;
            tableLayoutChannel.Location = new Point(11, 3);
            tableLayoutChannel.Name = "tableLayoutChannel";
            tableLayoutChannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutChannel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutChannel.Size = new Size(176, 40);
            tableLayoutChannel.TabIndex = 4;
            // 
            // LabelChannelName
            // 
            LabelChannelName.Anchor = AnchorStyles.None;
            LabelChannelName.AutoSize = true;
            LabelChannelName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelChannelName.Location = new Point(8, 1);
            LabelChannelName.Name = "LabelChannelName";
            LabelChannelName.Size = new Size(160, 18);
            LabelChannelName.TabIndex = 0;
            LabelChannelName.Text = "DİJİTAL SENSÖRLER";
            // 
            // LabelChannelDescription
            // 
            LabelChannelDescription.Anchor = AnchorStyles.Top;
            LabelChannelDescription.AutoSize = true;
            LabelChannelDescription.Font = new Font("Arial", 8.25F);
            LabelChannelDescription.Location = new Point(42, 20);
            LabelChannelDescription.Name = "LabelChannelDescription";
            LabelChannelDescription.Size = new Size(92, 14);
            LabelChannelDescription.TabIndex = 1;
            LabelChannelDescription.Text = "SENSÖR İSİMLERİ";
            // 
            // tableLayoutDataState
            // 
            tableLayoutDataState.ColumnCount = 1;
            tableLayoutDataState.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutDataState.Controls.Add(LabelDataStateTitle, 0, 0);
            tableLayoutDataState.Controls.Add(LabelDataStateDescription, 0, 1);
            tableLayoutDataState.Dock = DockStyle.Fill;
            tableLayoutDataState.Location = new Point(395, 3);
            tableLayoutDataState.Name = "tableLayoutDataState";
            tableLayoutDataState.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutDataState.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutDataState.Size = new Size(179, 40);
            tableLayoutDataState.TabIndex = 5;
            // 
            // LabelDataStateTitle
            // 
            LabelDataStateTitle.Anchor = AnchorStyles.Bottom;
            LabelDataStateTitle.AutoSize = true;
            LabelDataStateTitle.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LabelDataStateTitle.Location = new Point(50, 6);
            LabelDataStateTitle.Name = "LabelDataStateTitle";
            LabelDataStateTitle.Size = new Size(79, 14);
            LabelDataStateTitle.TabIndex = 0;
            LabelDataStateTitle.Text = "VERİ DURUMU";
            // 
            // LabelDataStateDescription
            // 
            LabelDataStateDescription.Anchor = AnchorStyles.Top;
            LabelDataStateDescription.AutoSize = true;
            LabelDataStateDescription.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelDataStateDescription.Location = new Point(83, 20);
            LabelDataStateDescription.Name = "LabelDataStateDescription";
            LabelDataStateDescription.Size = new Size(13, 18);
            LabelDataStateDescription.TabIndex = 1;
            LabelDataStateDescription.Text = "-";
            // 
            // DigitalSensorBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutMain);
            Name = "DigitalSensorBar";
            Size = new Size(579, 48);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutContent.ResumeLayout(false);
            tableLayoutSystemState.ResumeLayout(false);
            tableLayoutSystemState.PerformLayout();
            tableLayoutChannel.ResumeLayout(false);
            tableLayoutChannel.PerformLayout();
            tableLayoutDataState.ResumeLayout(false);
            tableLayoutDataState.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutContent;
        private Panel PanelState;
        private Panel Splitter1;
        private Panel Splitter2;
        private TableLayoutPanel tableLayoutChannel;
        private Label LabelChannelName;
        private Label LabelChannelDescription;
        private TableLayoutPanel tableLayoutSystemState;
        private Label LabelSystemStateTitle;
        private Label LabelSystemStateDescription;
        private TableLayoutPanel tableLayoutDataState;
        private Label LabelDataStateTitle;
        private Label LabelDataStateDescription;
    }
}