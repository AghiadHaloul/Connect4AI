using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Connect4AI
{
    class Game
    {
        public char[,] gird = new char[6,7];
        public int[] top = new int[7];
        //private char[,] grid;
        public void Reset()
        {
            for (int j = 0; j < 7; j++)
            {
                this.top[j] = 5;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.gird[i,j] = '-';
                }
            }
        }
        public Game()
        {
            Reset();
        }
        public void Restart()
        {
            Reset();
        }
        public string CheckWinner()
        {
            string row = "", column = "", diagR = "", diagL = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    row = column = diagR = diagL = "";
                    for (int k = j,c=0; k < 7 && c<4; k++,c++)
                    {
                        row += this.gird[i, k];
                    }
                    for (int k = i,c=0; k < 6&& c<4; k++,c++)
                    {
                        column += this.gird[k, j];
                    }
                    for (int k = 0,c=0; k < 4 && i + k < 6 && j + k < 7 && c<4; k++,c++)
                    {
                        diagR += this.gird[i + k, j + k];
                    }
                    for (int k = 0,c=0; k < 4 && i + k < 6 && j - k >= 0 && c<4; k++,c++)
                    {
                        diagL += this.gird[i + k, j - k];
                    }
                    if (row.Contains("rrrr") == true || column.Contains("rrrr") == true || diagR.Contains("rrrr") == true || diagL.Contains("rrrr") == true)
                    {
                        return "RED";
                    }
                    if (row.Contains("yyyy") == true || column.Contains("yyyy") == true || diagR.Contains("yyyy") == true || diagL.Contains("yyyy") == true)
                    {
                        return "YELLOW";
                    }
                }
            }
            bool draw = true;
            for (int j = 0; j < 7; j++)
            {
                if (this.top[j] != -1)
                {
                    draw = false;
                }
            }
            if (draw == true)
            {
                return "draw";
            }
            return "";
        }

    }
}
