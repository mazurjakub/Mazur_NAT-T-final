using System;
using System.Windows.Forms;

namespace Mazur_NAT_T
{
    static class Program
    {
        /// <summary>
        /// Main entry point of app.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
        }
    }
}
