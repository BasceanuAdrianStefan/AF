using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Snake2
{

    internal class Player
    {
        public List<Point> Snake { get; private set; }
        public string Direction { get; private set; } = "Right";
        private Color color = Color.Green;
        private int gridSize = 30;
        public bool isGameOver;
        public bool boost;


        public Player()
        {
            Snake = new List<Point>
                 {
                     new Point(5, 5),
                     new Point(4, 5),
                     new Point(3, 5)
                    };
            boost = false;
            isGameOver = false;
        }

        public void ChangeMovement(Keys key)
        {
            if (key == Keys.W && Direction != "Down")
                Direction = "Up";
            else if (key == Keys.S && Direction != "Up")
                Direction = "Down";
            else if (key == Keys.A && Direction != "Right")
                Direction = "Left";
            else if (key == Keys.D && Direction != "Left")
                Direction = "Right";
            if (key == Keys.Space)
                boost = !boost;

        }

        public void Move()
        {
            Point head = Snake[0];
            Point newHead = head;


            switch (Direction)
            {
                case "Up":
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case "Down":
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case "Left":
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case "Right":
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }
            if (newHead.X < 0 || newHead.X >= 25 || newHead.Y < 0 || newHead.Y >= 25)
                isGameOver = true;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (newHead == Snake[i])
                {
                    isGameOver = true;
                    break;
                }

            }

            Snake.Insert(0, newHead);
            Snake.RemoveAt(Snake.Count - 1);

        }

        public void Grow()
        {
            Point tail = Snake[Snake.Count - 1];
            Snake.Add(tail);
        }

        public void Draw(Graphics g)
        {
            foreach (Point p in Snake)
            {
                g.FillRectangle(new SolidBrush(color), p.X * gridSize, p.Y * gridSize, gridSize, gridSize);
                g.DrawRectangle(Pens.Black, p.X * gridSize, p.Y * gridSize, gridSize, gridSize);
            }
        }

    }
}

