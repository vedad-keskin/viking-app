using System;
using System.Drawing;
using System.Windows.Forms;

namespace Viking.WinApp.Forms
{
    public partial class frmLoading : Form
    {
        private int angle = 0;

        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Paint(object sender, PaintEventArgs e)
        {
            DrawLoadingCircle(e.Graphics);
        }

        private void DrawLoadingCircle(Graphics g)
        {
            int size = 50;
            int thickness = 5;
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2 - 10;
            Rectangle rect = new Rectangle(centerX - size / 2, centerY - size / 2, size, size);

            using (Pen pen = new Pen(Color.DodgerBlue, thickness))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawArc(pen, rect, angle, 270);
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            angle += 6;
            this.Invalidate();
        }
    }
}
