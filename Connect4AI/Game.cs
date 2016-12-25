using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4AI
{
    class Game
    {
        public char[,] gird = new char[6, 7];
        public int[] top = new int[7];
        public Game()
        {
            for (int j = 0; j < 7; j++)
            {
                this.top[j] = 5;
            }
        }
        public string CheckWinner()
        {
            string row;
            for (int i = 0; i < 6; i++)
            {
                row = "";
                for (int j = 0; j < 7; j++)
                {
                    row += this.gird[i, j];
                }
                if (row.Contains("rrrr") == true)
                    return "RED";
                if (row.Contains("yyyy") == true)
                    return "YELLOW";
            }
            for (int j = 0; j < 7; j++)
            {
                row = "";
                for (int i = 0; i < 6; i++)
                {
                    row += this.gird[i, j];
                }
                if (row.Contains("rrrr") == true)
                    return "RED";
                if (row.Contains("yyyy") == true)
                    return "YELLOW";
            }

            //TODO: Check winner in diagonal.
            bool draw = true;
            for (int j = 0; j < 7; j++)
            {
                if(this.top[j]!=-1)
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
