using System;
using System.Drawing;
using System.Windows.Forms;

public class control_btns : Button
{
    private Color buttonColor;

    public control_btns(Color color)
    {
        buttonColor = color;
        FlatStyle = FlatStyle.Flat;
        BackColor = buttonColor;
        ForeColor = Color.White;
        Font = new Font("Arial", 12, FontStyle.Bold);
        Size = new Size(50, 50);
        Text = "";
        Padding = new Padding(0);
        FlatAppearance.BorderSize = 0;
        Region = new Region(new Rectangle(0, 0, Width, Height));
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        using (var brush = new SolidBrush(buttonColor))
        {
            e.Graphics.FillEllipse(brush, new RectangleF(0, 0, Width, Height));
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Region = new Region(new Rectangle(0, 0, Width, Height));
    }
}