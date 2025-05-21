using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake2
{
    public partial class Form1 : Form
    {
        Timer gameTimer = new Timer();
        Player player;
        Food food;
        int gridSize = 30;
        
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 25*gridSize;
            this.Height = 25*gridSize;
            
            
            player = new Player();
            food = new Food();
            
            gameTimer.Interval = 150;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
           
            player.ChangeMovement(e.KeyCode);
           
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (player.Snake[0].X*gridSize == food.Location.X && player.Snake[0].Y*gridSize == food.Location.Y)
            {
                player.Grow();
                food.Respawn(player.Snake);
            }
            if(player.boost == true)
            {
                gameTimer.Interval = 50;
            }
            else
            {
                gameTimer.Interval = 150;
            }
            player.Move();
            this.Invalidate();
            if (player.isGameOver==true)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over");
                this.Close();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            player.Draw(e.Graphics);
            food.Draw(e.Graphics);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
