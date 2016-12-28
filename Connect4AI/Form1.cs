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
        public Game game;
        public Drawer drawer = new Drawer();
        bool red = false, gameOver = false;
        int counter = 0;
        public int mode = 0;
        public int diff;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            drawer.DrawGrid(this.gamePanel);
            LocateLabels();
            SetDifficulty(diff);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            drawer.DrawGrid(this.gamePanel);
        }
        public void LocateLabels()
        {
            int x = gamePanel.Location.X+((gamePanel.Width / 14) / 2);
            int y = Convert.ToInt32( 6.80 * (gamePanel.Width / 7));
            gainLabel.Location = new Point(10, y);
            c1label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c2label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c3label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c4label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c5label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c6label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
            c7label.Location = new Point(x, y);
            x += (gamePanel.Width / 7) + 5;
        }
        public void UpdateLabels(int [] arr)
        {
            c1label.Text = arr[0].ToString();
            c2label.Text = arr[1].ToString();
            c3label.Text = arr[2].ToString();
            c4label.Text = arr[3].ToString();
            c5label.Text = arr[4].ToString();
            c6label.Text = arr[5].ToString();
            c7label.Text = arr[6].ToString();
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
            switch (this.mode)
            {
                case 0:
                    Cursor.Current = Cursors.WaitCursor;
                    playerVsAI(column, row);
                    Cursor.Current = Cursors.Default;
                    break;
                case 1:
                    playerVsPlayer(column, row);
                    break;
                case 2:
                    aiVsAi();
                    break;
                default:
                    break;
            }

        }
        public bool check()
        {
            string check = game.CheckWinner();
            if (check != "")
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
                return true;
            }
            return false;
        }
        
        public void playerVsAI(int column, int row)
        {
            drawer.DrawDisk(column, row, Color.Yellow,false);
            game.AddDisk(row, column, 'y');
            if (check() == true)
                return;
            column = game.CalcMove(this);
            row = game.top[column];
            drawer.DrawDisk(column, row, Color.Red,true);
            game.AddDisk(row, column, 'r');
            check();       
        }
        public void playerVsPlayer(int column, int row)
        {

            if (red == true)
            {
                drawer.DrawDisk(column, row, Color.Red,false);
                red = false;
                game.AddDisk(row, column, 'r');
            }
            else
            {
                drawer.DrawDisk(column, row, Color.Yellow, false);
                red = true;
                game.AddDisk(row, column, 'y');
            }
            string check = game.CheckWinner();
            if (check != "")
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
        }
        public void aiVsAi()
        {
            //TODO
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
        public void SetDifficulty(int depth)
        {
            game.max_depth = depth;
        }
        
    }
}
