using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Connect4AI
{
    public class Game
    {
        public int max_depth = 5;
        public char[,] grid = new char[6,7];
        public int[] top = new int[7];
        public int[] score = new int[7];
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
                    this.grid[i,j] = '-';
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
                        row += this.grid[i, k];
                    }
                    for (int k = i,c=0; k < 6&& c<4; k++,c++)
                    {
                        column += this.grid[k, j];
                    }
                    for (int k = 0,c=0; k < 4 && i + k < 6 && j + k < 7 && c<4; k++,c++)
                    {
                        diagR += this.grid[i + k, j + k];
                    }
                    for (int k = 0,c=0; k < 4 && i + k < 6 && j - k >= 0 && c<4; k++,c++)
                    {
                        diagL += this.grid[i + k, j - k];
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
            int occupiedCellsAtTopRow = 0;
            for (int j = 0; j < 7; j++)
            {
                if(this.grid[0,j]!='-')
                {
                    occupiedCellsAtTopRow++;
                }
            }
            if (occupiedCellsAtTopRow == 7)
            {
                return "draw";
            }
            return "";
        }
        public void AddDisk(int row,int column,char c)
        {
            this.grid[row, column] = c;
            this.top[column]--;
        }
        public void RemoveDisk(int row,int column)
        {
            this.grid[row,column]='-';
            this.top[column]++;
        }
        public int CalcMove(Connect4AI.Form1 ourForm)
        {
            int maxRet = -int.MaxValue;
            int move=-1;
            for (int i = 0; i < 7; i++)
            {
                int row = this.top[i];
                if (row >= 0)
                {
                    score[i] = Minimax(row, i, 'r', 1, ourForm);
                    if (score[i] > maxRet)
                    {
                        maxRet = score[i];
                        move = i;
                    }
                }
            }
            Program.theForm.UpdateLabels(score);
            return move;
        }
        //public int row = game.top[column];
        public int Minimax(int row, int column, char colorChar,int depth, Connect4AI.Form1 ourForm)
        {
            if (depth == max_depth)
                return 0;
            AddDisk(row, column, colorChar);
            int inputRow = row, inputColumn = column,ret = 0;
            if (CheckWinner() == "RED")
            {
                ret=1;
                RemoveDisk(inputRow, inputColumn);
                for (int i = max_depth-depth; i > 0; i--)
                {
                    ret *= 10;
                }
                return ret;
            }
            else if (CheckWinner() == "YELLOW")
            {
                ret=-1;
                RemoveDisk(inputRow, inputColumn);
                for (int i = max_depth - depth; i > 0; i--)
                {
                    ret *= 10;
                }
                return ret;
            }
            else if (CheckWinner() == "")
            {
                char color;
                if (colorChar == 'r')
                {
                    color = 'y';    
                }
                else
                {
                    color = 'r';
                }
                for (int i = 0; i < 7; i++)
                {
                    row = this.top[i];
                    if (row >= 0)
                    {
                        ret = ret+Minimax(row, i, color,depth+1, ourForm);
                    }
                }
                RemoveDisk(inputRow, inputColumn);
                return ret;
            }
            else
            {
                RemoveDisk(inputRow, inputColumn);
                return 0;
            }
        }
    }
}
