using System;
using System.Drawing;
using System.Windows.Forms;
using WinUI.Helpers; 

namespace WinUI.Controls.IBKS.Sidebar
{
    public partial class ButtonSideBar : UserControl
    {
        private static ButtonSideBar _selectedButton;
        private System.Windows.Forms.Button innerButton;

        private Color _hoverColor = Color.FromArgb(230, 230, 230);
        private Color _selectedBackColor = Color.FromArgb(230, 230, 230);
        private Color _normalBackColor = Color.White;
        private int _borderRadius = 10;

        public event EventHandler Clicked;

        public ButtonSideBar()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            this.Dock = DockStyle.Fill;
            this.Margin = new Padding(8);
            this.Padding = new Padding(0);
            this.BackColor = Color.Transparent;

            innerButton = new System.Windows.Forms.Button();
            innerButton.Dock = DockStyle.Fill;
            innerButton.ForeColor = Color.DimGray;
            innerButton.BackColor = _normalBackColor;
            innerButton.ImageAlign = ContentAlignment.MiddleLeft;
            innerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            innerButton.TextAlign = ContentAlignment.MiddleLeft;
            innerButton.Padding = new Padding(10, 0, 0, 0);

            innerButton.MouseEnter += (s, e) =>
            {
                if (_selectedButton != this)
                    innerButton.BackColor = _hoverColor;
            };

            innerButton.MouseLeave += (s, e) =>
            {
                if (_selectedButton != this)
                    innerButton.BackColor = _normalBackColor;
            };

            innerButton.Click += (s, e) =>
            {
                if (_selectedButton != null && _selectedButton != this)
                    _selectedButton.Deselect();

                _selectedButton = this;
                innerButton.BackColor = _selectedBackColor;
                Clicked?.Invoke(this, EventArgs.Empty);
            };

            this.Controls.Add(innerButton);
        }

        public void Deselect()
        {
            innerButton.BackColor = _normalBackColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RoundedCorners.MakeRounded(innerButton, _borderRadius);
        }

        // === Özelleştirilebilir özellikler ===

        public string ButtonText
        {
            get => innerButton.Text;
            set => innerButton.Text = value;
        }

        public Image ButtonIcon
        {
            get => innerButton.Image;
            set => innerButton.Image = value;
        }

        public Color HoverColor
        {
            get => _hoverColor;
            set => _hoverColor = value;
        }

        public Color SelectedBackColor
        {
            get => _selectedBackColor;
            set => _selectedBackColor = value;
        }

        public Color NormalBackColor
        {
            get => _normalBackColor;
            set
            {
                _normalBackColor = value;
                if (_selectedButton != this)
                    innerButton.BackColor = value;
            }
        }

        public Color TextColor
        {
            get => innerButton.ForeColor;
            set => innerButton.ForeColor = value;
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                RoundedCorners.MakeRounded(innerButton, value);
            }
        }
    }
}
