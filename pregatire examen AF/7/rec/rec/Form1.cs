using System.CodeDom.Compiler;

namespace rec
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        List<PointF> points = new List<PointF>();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PointF pointF = new PointF(e.X, e.Y);
            points.Add(pointF);
            graphics.FillEllipse(Brushes.Red, e.X - 5, e.Y - 5, 10, 10);
            if(points.Count > 1)
            {
                graphics.DrawLine(Pens.Black, points[points.Count - 2], points[points.Count - 1]);
            }
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.Black, points[0], points[points.Count - 1]);
            pictureBox1.Image = bitmap;
            rec(1,points);
        }
        private void rec(int n,List<PointF> p)
        {
            if(n>100)
                return;
            List<PointF> newPoints = new List<PointF>();
            for (int i = 0; i < p.Count - 1; i++)
            {
                PointF midPoint = new PointF((p[i].X/2 + p[i + 1].X) / 2, (p[i].Y/2 + p[i + 1].Y) / 2);
                newPoints.Add(midPoint);
                
            }
            graphics.DrawLine(Pens.Blue, p[0], newPoints[0]);
            for (int i = 0; i < newPoints.Count - 1; i++)
            {
                graphics.DrawLine(Pens.Blue, newPoints[i], newPoints[i + 1]);
            }
            pictureBox1.Image = bitmap;
            rec(n +1, points);
        }
    }
}
