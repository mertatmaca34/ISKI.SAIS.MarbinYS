using System.ComponentModel;

namespace WinUI.Controls.IBKS
{
    partial class DigitalSensorControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private TableLayoutPanel tableLayoutPanelMain;
        private Panel PanelSensorState;
        private TableLayoutPanel tableSensorInfo;
        private Label LabelSensorName;
        private Label LabelSensorDescription;

        private void InitializeComponent()
        {
            tableLayoutPanelMain = new TableLayoutPanel();
            PanelSensorState = new Panel();
            tableSensorInfo = new TableLayoutPanel();
            LabelSensorName = new Label();
            LabelSensorDescription = new Label();
            tableLayoutPanelMain.SuspendLayout();
            tableSensorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.BackColor = Color.White;
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(PanelSensorState, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableSensorInfo, 1, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(1, 1);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(198, 46);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // PanelSensorState
            // 
            PanelSensorState.BackColor = Color.Gray;
            PanelSensorState.Dock = DockStyle.Fill;
            PanelSensorState.Location = new Point(0, 0);
            PanelSensorState.Margin = new Padding(0);
            PanelSensorState.Name = "PanelSensorState";
            PanelSensorState.Size = new Size(8, 46);
            PanelSensorState.TabIndex = 0;
            // 
            // tableSensorInfo
            // 
            tableSensorInfo.BackColor = Color.White;
            tableSensorInfo.ColumnCount = 1;
            tableSensorInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableSensorInfo.Controls.Add(LabelSensorName, 0, 0);
            tableSensorInfo.Controls.Add(LabelSensorDescription, 0, 1);
            tableSensorInfo.Dock = DockStyle.Fill;
            tableSensorInfo.Location = new Point(9, 1);
            tableSensorInfo.Margin = new Padding(1);
            tableSensorInfo.Name = "tableSensorInfo";
            tableSensorInfo.RowCount = 2;
            tableSensorInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableSensorInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableSensorInfo.Size = new Size(188, 44);
            tableSensorInfo.TabIndex = 1;
            // 
            // LabelSensorName
            // 
            LabelSensorName.Anchor = AnchorStyles.Bottom;
            LabelSensorName.AutoSize = true;
            LabelSensorName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            LabelSensorName.Location = new Point(87, 8);
            LabelSensorName.Name = "LabelSensorName";
            LabelSensorName.Size = new Size(13, 18);
            LabelSensorName.TabIndex = 0;
            LabelSensorName.Text = "-";
            // 
            // LabelSensorDescription
            // 
            LabelSensorDescription.Anchor = AnchorStyles.Top;
            LabelSensorDescription.AutoSize = true;
            LabelSensorDescription.Font = new Font("Arial", 8.25F);
            LabelSensorDescription.Location = new Point(88, 26);
            LabelSensorDescription.Name = "LabelSensorDescription";
            LabelSensorDescription.Size = new Size(11, 14);
            LabelSensorDescription.TabIndex = 1;
            LabelSensorDescription.Text = "-";
            // 
            // DigitalSensorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(0);
            Name = "DigitalSensorControl";
            Padding = new Padding(1);
            Size = new Size(200, 48);
            tableLayoutPanelMain.ResumeLayout(false);
            tableSensorInfo.ResumeLayout(false);
            tableSensorInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
