namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<PointF> points = new List<PointF>();
        Bitmap bitmap;
        Graphics graphics;
        Pen p = new Pen (Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(p, points[0], points[points.Count - 1]);
            pictureBox1.Image = bitmap;
            Rec(points);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PointF point = e.Location;
            points.Add(point);
            graphics.FillEllipse(Brushes.Red, point.X - 5, point.Y - 5, 10, 10);
            if(points.Count > 1)
            {
                graphics.DrawLine(p, points[points.Count - 1], points[points.Count - 2]);
            }
            pictureBox1.Image = bitmap;
        }
        private float Distance(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
        private void Rec(List<PointF> puncte)
        {
            if(Distance(puncte[0], puncte[puncte.Count - 1]) < 5)
            {
                return;
            }
            List<PointF> newpoints = new List<PointF>();
            for(int i = 0;i<puncte.Count-1;i++)
            {
                PointF m = new PointF((puncte[i].X + puncte[i + 1].X) / 2, (puncte[i].Y + puncte[i+1].Y)/2);
                newpoints.Add(m);
            }
            PointF mij = new PointF((puncte[puncte.Count - 1].X + puncte[0].X) / 2, (puncte[puncte.Count - 1].Y + puncte[0].Y) / 2);
            newpoints.Add(mij);
            for (int i = 1; i < newpoints.Count; i++)
            {
                graphics.DrawLine(p, newpoints[i-1], newpoints[i]);
            }
            graphics.DrawLine(p,newpoints[0],newpoints[newpoints.Count-1]);
            
            pictureBox1.Image = bitmap;
            Rec(newpoints);
        }
    }
}
