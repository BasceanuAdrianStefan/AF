using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Food
    {
        public Point Location { get; private set; }
        private Color color = Color.Red;
        private int gridSize = 30;
        private Random random = new Random();

        public Food()
        {
            Respawn();
            
        }

        public void Respawn(List<Point> snakeBody = null)
        {
            Point newLocation;
            do
            {
                newLocation = new Point(random.Next(0, 20), random.Next(0, 20));
            }
            while (snakeBody != null && snakeBody.Contains(newLocation));

            Location = new Point(newLocation.X * gridSize, newLocation.Y * gridSize);
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, new Rectangle(Location.X, Location.Y, gridSize, gridSize));
            }
        }
    }
}
