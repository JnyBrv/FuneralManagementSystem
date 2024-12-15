using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuneralManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            Application.Run(new FrmPackages());
            
        }

        /* Notes
         * archive in CLIENT Table
         * 0 - active clients
         * 1 - deleted
         * 2 - paying clients
         * 3 - completed transactions
         */
    }
}
