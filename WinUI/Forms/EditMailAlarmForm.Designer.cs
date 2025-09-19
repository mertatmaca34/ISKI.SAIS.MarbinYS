using System.Drawing;
using System.Windows.Forms;

namespace WinUI.Forms
{
    partial class EditMailAlarmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMailAlarmForm));
            nameLabel = new Label();
            channelLabel = new Label();
            limitLabel = new Label();
            subjectLabel = new Label();
            bodyLabel = new Label();
            nameTextBox = new TextBox();
            channelComboBox = new ComboBox();
            limitNumericUpDown = new NumericUpDown();
            subjectTextBox = new TextBox();
            bodyTextBox = new TextBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Alarm Adı";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(110, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 23);
            nameTextBox.TabIndex = 0;
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Location = new Point(12, 45);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(41, 15);
            channelLabel.TabIndex = 0;
            channelLabel.Text = "Kanal";
            // 
            // channelComboBox
            // 
            channelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            channelComboBox.Location = new Point(110, 42);
            channelComboBox.Name = "channelComboBox";
            channelComboBox.Size = new Size(250, 23);
            channelComboBox.TabIndex = 1;
            // 
            // limitLabel
            // 
            limitLabel.AutoSize = true;
            limitLabel.Location = new Point(12, 75);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(32, 15);
            limitLabel.TabIndex = 0;
            limitLabel.Text = "Limit";
            // 
            // limitNumericUpDown
            // 
            limitNumericUpDown.DecimalPlaces = 2;
            limitNumericUpDown.Location = new Point(110, 72);
            limitNumericUpDown.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            limitNumericUpDown.Name = "limitNumericUpDown";
            limitNumericUpDown.Size = new Size(120, 23);
            limitNumericUpDown.TabIndex = 2;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(12, 105);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(75, 15);
            subjectLabel.TabIndex = 0;
            subjectLabel.Text = "Mail Konusu";
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(110, 102);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(250, 23);
            subjectTextBox.TabIndex = 3;
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Location = new Point(12, 135);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(67, 15);
            bodyLabel.TabIndex = 0;
            bodyLabel.Text = "Mail İçeriği";
            // 
            // bodyTextBox
            // 
            bodyTextBox.Location = new Point(110, 132);
            bodyTextBox.Multiline = true;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.Size = new Size(250, 80);
            bodyTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(285, 220);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Kaydet";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // EditMailAlarmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 260);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(channelLabel);
            Controls.Add(channelComboBox);
            Controls.Add(limitLabel);
            Controls.Add(limitNumericUpDown);
            Controls.Add(subjectLabel);
            Controls.Add(subjectTextBox);
            Controls.Add(bodyLabel);
            Controls.Add(bodyTextBox);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditMailAlarmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm Düzenle";
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label channelLabel;
        private Label limitLabel;
        private Label subjectLabel;
        private Label bodyLabel;
        private TextBox nameTextBox;
        private ComboBox channelComboBox;
        private NumericUpDown limitNumericUpDown;
        private TextBox subjectTextBox;
        private TextBox bodyTextBox;
        private Button saveButton;
    }
}
