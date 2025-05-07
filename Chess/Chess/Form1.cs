using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        private const int GridSize = 8;
        private const int SquareSize = 120;
        
        public Form1()
        {
            InitializeComponent();
            CreateChessboard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CreateChessboard()
        {
            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    Panel square = new Panel
                    {
                        Width = SquareSize,
                        Height = SquareSize,
                        Left = col * SquareSize,
                        Top = row * SquareSize,
                        BackColor = (row + col) % 2 == 0 ? Color.White : Color.Black,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    this.Controls.Add(square);
                }
            }
            this.ClientSize = new Size(GridSize * SquareSize, GridSize * SquareSize);

        }
    }
}
