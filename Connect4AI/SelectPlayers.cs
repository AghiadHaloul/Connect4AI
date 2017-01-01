using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Connect4AI
{
    public partial class SelectPlayers : Form
    {
        public SelectPlayers()
        {
            InitializeComponent();
            System.IO.File.WriteAllText(@"E:\Work\4th Year - 1st Semestre\Mathematical Programming\Project\Connect4AI\Connect4AI\logfile.txt", string.Empty);
        }
        public void ViewGameForm(int mode,int depth)
        {
            Program.theForm.mode = mode;
            Program.theForm.diff = depth;
            Program.theForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ViewGameForm(0,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewGameForm(1,-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewGameForm(2,6);
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            ViewGameForm(0, 3);
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            ViewGameForm(0, 5);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
