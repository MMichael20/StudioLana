using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

//public class MyGrid: DataGridView
//{
//    public int BorderRadius { get; set; } = 30; // Set your desired border radius

//    protected override void OnPaint(PaintEventArgs e)
//    {
//        base.OnPaint(e);

//        // Get the border color and width
//        var borderColor = Color.FromArgb(137, 207, 240); // Set your desired border color
//        var borderWidth = 2; // Set your desired border width

//        // Create a GraphicsPath to define the rounded border
//        GraphicsPath path = new GraphicsPath();
//        int width = this.Width;
//        int height = this.Height;

//        int borderRadius = BorderRadius;

//        path.StartFigure();
//        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
//        path.AddArc(width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
//        path.AddArc(width - borderRadius, height - borderRadius, borderRadius, borderRadius, 0, 90);
//        path.AddArc(0, height - borderRadius, borderRadius, borderRadius, 90, 90);
//        path.CloseFigure();

//        // Draw the rounded border
//        using (Pen pen = new Pen(borderColor, borderWidth))
//        {
//            this.Region = new System.Drawing.Region(path);
//            e.Graphics.DrawPath(pen, path);
//        }
//    }

//}

public class MyGrid : DataGridView
{
    public int BorderRadius { get; set; } = 30; // Set your desired border radius

    public MyGrid()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        UpdateStyles();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Get the border color and width
        var borderColor = Color.FromArgb(137, 207, 240); // Set your desired border color
        var borderWidth = 2; // Set your desired border width

        // Create a GraphicsPath to define the rounded border
        GraphicsPath path = new GraphicsPath();
        int width = this.Width;
        int height = this.Height;

        int borderRadius = BorderRadius;

        path.StartFigure();
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(width - borderRadius, height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, height - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseFigure();

        // Draw the rounded border
        using (Pen pen = new Pen(borderColor, borderWidth))
        {
            this.Region = new System.Drawing.Region(path);
            e.Graphics.DrawPath(pen, path);
        }
    }
}