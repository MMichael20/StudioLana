using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    static class Program
    {
        public static Main play;
        //public static Login Load;
        //public static Login Load;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            play = new Main();
            //Load = new Login();
            Application.Run(play);
            //Application.Run(Load);
            
        }
    }
}
