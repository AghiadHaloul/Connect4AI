using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4AI
{
    static class Program
    {
        public static Form1 theForm = new Form1();
        public static SelectPlayers selectionForm = new SelectPlayers();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectPlayers());
        }
    }
}
