using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
namespace Connect4AI
{
    public class Drawer
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
            for (int i = 0; i < 6; i++)
            {
                startX = 0;
                for(int j=0;j<7;j++)
                {
                    DrawGridBrick(startX, startY, width, height, Color.Blue, "Rectangle");
                    if (Program.theForm.game.gird[i, j] == '-')
                    {
                        DrawGridBrick(startX + 5, startY + 5, width - 10, height - 10, Color.White, "Ellipse");
                    }
                    if (Program.theForm.game.gird[i, j] == 'r')
                    {
                        DrawGridBrick(startX + 5, startY + 5, width - 10, height - 10, Color.Red, "Ellipse");
                    }
                    if (Program.theForm.game.gird[i, j] == 'y')
                    {
                        DrawGridBrick(startX + 5, startY + 5, width - 10, height - 10, Color.Yellow, "Ellipse");
                    }
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
        public void DrawDisk(int column, int row, Color color,bool AI)
        {
            int startX;
            int startY;
            int width;
            int height;
            if (AI == false)
            {
                pen = new Pen(color);
                solidBrush = new SolidBrush(color);
                startX = column * (gamePanel.Width / 7) + 5;
                startY = gamePanel.Width / 14 + (row * (gamePanel.Height / 7) + 5);
                width = (gamePanel.Width / 7) - 10;
                height = (gamePanel.Width / 7) - 10;
                g.DrawEllipse(pen, startX, startY, width, height);
                g.DrawEllipse(pen, startX, startY, width, height);
                g.FillEllipse(solidBrush, startX, startY, width, height);
                return;
            }

            pen = new Pen(Color.Red);
            solidBrush = new SolidBrush(Color.Red);
            startX = column * (gamePanel.Width / 7) + 5;
            startY = gamePanel.Width / 14 + (row * (gamePanel.Height / 7) + 5);
            width = (gamePanel.Width / 7) - 10;
            height = (gamePanel.Width / 7) - 10;
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);
            Thread.Sleep(100);

            pen = new Pen(Color.White);
            solidBrush = new SolidBrush(Color.White);
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);
            Thread.Sleep(100);

            pen = new Pen(Color.Red);
            solidBrush = new SolidBrush(Color.Red);
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);
            Thread.Sleep(100);

            pen = new Pen(Color.White);
            solidBrush = new SolidBrush(Color.White);
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);
            Thread.Sleep(100);


            pen = new Pen(color);
            solidBrush = new SolidBrush(color);
            g.DrawEllipse(pen, startX, startY, width, height);
            g.FillEllipse(solidBrush, startX, startY, width, height);

            
        }
    }
}
