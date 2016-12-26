using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4AI
{
    public partial class Form1 : Form
    {
        Game game;
        Drawer drawer = new Drawer();
        bool red = false, gameOver = false;
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            drawer.DrawGrid(this.gamePanel);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawer.DrawGrid(this.gamePanel);
        }

        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameOver == true) 
                return;
            counter++;
            int column = Convert.ToInt32(Math.Floor(((Convert.ToDouble(e.X) / Convert.ToDouble(gamePanel.Width)))*7));
            int row = game.top[column];
            if(row<0)
            {
                MessageBox.Show("This column is full!");
                return;
            }
            if(red==true)
            {
                drawer.AddDisk(column, row, Color.Red);
                red = false;
                game.gird[row, column] = 'r';
            }
            else
            {
                drawer.AddDisk(column, row, Color.Yellow);
                red = true;
                game.gird[row, column] = 'y';
            }
            string check = game.CheckWinner();
            if(check!="")
            {
                if (check == "draw")
                {
                    label2.Text = "Draw";
                }
                else
                {
                    label2.Text = check + " WON!!";
                }
                label2.Visible = true;
                gameOver = true;
            }
            game.top[column]--;
            
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            drawer.DrawGrid(this.gamePanel);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            game.Restart();
            drawer.DrawGrid(gamePanel);
            gameOver = false;
            label2.Visible = false;
        }

        
    }
}
