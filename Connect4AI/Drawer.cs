using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connect4AI
{
    class Drawer
    {
        Graphics g;
        Pen pen;
        SolidBrush solidBrush;
        System.Windows.Forms.Panel gamePanel;
        public void DrawGrid(System.Windows.Forms.Panel panel)
        {
            gamePanel = panel;
            g = gamePanel.CreateGraphics();
            int startX = gamePanel.Width / 14;
            int startY = gamePanel.Width / 14;
            int width = (gamePanel.Width / 7);
            int height = (gamePanel.Width / 7);
            for (int i = 0; i < 6;i++)
            {
                startX = 0;
                for(int j=0;j<7;j++)
                {
                    DrawGridBrick(startX, startY, width, height, Color.Blue, "Rectangle");
                    DrawGridBrick(startX + 5, startY + 5, width - 10, height - 10, Color.White, "Ellipse");
                    startX += (gamePanel.Width / 7);
                }
                startY += (gamePanel.Height / 7);
            }
        }
        public void DrawGridBrick(int startX,int startY,int width,int height, Color color,string type)
        {
            pen = new Pen(color);
            solidBrush = new SolidBrush(color);
            if(type=="Rectangle")
            {
                g.DrawRectangle(pen, startX, startY, width, height);
                g.FillRectangle(solidBrush, startX, startY, width, height);
            }
            else if(type == "Ellipse")
            {
                g.DrawEllipse(pen, startX, startY, width, height);
                g.FillEllipse(solidBrush, startX, startY, width, height);
            }
        }
        public void AddDisk(int column,int row,Color color)
        {
            pen = new Pen(color);
            solidBrush = new SolidBrush(color);
            int startX = column * (gamePanel.Width / 7)+5;
            int startY = gamePanel.Width / 14 + (row * (gamePanel.Height / 7) + 5);
            int width = (gamePanel.Width / 7)-10;
            int height = (gamePanel.Width / 7)-10;
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);
        }
    }
}
