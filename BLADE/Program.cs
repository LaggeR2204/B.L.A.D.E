using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BLADE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm frmLI = new LoginForm();
            Application.Run(frmLI);
            if(frmLI.loginState == 0 || frmLI.loginState == 1)
            {
                MainForm main = new MainForm();
                main.SetUserName(frmLI._username);
                Application.Run(main);
            }
        }
    }
}
