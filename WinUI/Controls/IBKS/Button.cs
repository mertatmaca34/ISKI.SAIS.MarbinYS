using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinUI.Controls.IBKS.Sidebar;

public partial class Button : UserControl
{
    private bool isHovered = false;
    private bool isClicked = false;

    public string ButtonText { get; set; } = "IBKS Buton";
    public Color BaseColor { get; set; } = Color.FromArgb(0, 130, 201);
    public Color TextColor { get; set; } = Color.White;
    public int BorderRadius { get; set; } = 12;

    public event EventHandler Clicked;

    public Button()
    {
        DoubleBuffered = true;
        Cursor = Cursors.Hand;
        Size = new Size(160, 45);
        Font = new Font("Segoe UI", 10F, FontStyle.Bold);

        MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
        MouseLeave += (s, e) => { isHovered = false; isClicked = false; Invalidate(); };
        MouseDown += (s, e) => { isClicked = true; Invalidate(); };
        MouseUp += (s, e) =>
        {
            isClicked = false;
            Invalidate();
            Clicked?.Invoke(this, EventArgs.Empty);
        };
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Color drawColor = BaseColor;
        if (isClicked)
            drawColor = AdjustColorBrightness(BaseColor, -0.05f); // %5 koyu
        else if (isHovered)
            drawColor = AdjustColorBrightness(BaseColor, 0.10f); // %10 parlak

        using (SolidBrush brush = new SolidBrush(drawColor))
        {
            using (GraphicsPath path = GetRoundRectPath(ClientRectangle, BorderRadius))
            {
                g.FillPath(brush, path);
            }
        }

        TextRenderer.DrawText(
            g,
            ButtonText,
            Font,
            ClientRectangle,
            TextColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }

    private GraphicsPath GetRoundRectPath(Rectangle rect, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }

    private Color AdjustColorBrightness(Color color, float factor)
    {
        float r = color.R / 255f;
        float g = color.G / 255f;
        float b = color.B / 255f;

        if (factor < 0)
        {
            r *= 1 + factor;
            g *= 1 + factor;
            b *= 1 + factor;
        }
        else
        {
            r += (1 - r) * factor;
            g += (1 - g) * factor;
            b += (1 - b) * factor;
        }

        return Color.FromArgb(color.A, Clamp(r), Clamp(g), Clamp(b));
    }

    private int Clamp(float val)
    {
        return (int)(Math.Max(0, Math.Min(1, val)) * 255);
    }
}