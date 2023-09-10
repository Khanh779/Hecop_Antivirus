using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool daChayRoi = false;
            using (Mutex mutex= new Mutex(true,Application.ProductName, out daChayRoi))
            {
                if(daChayRoi==true)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(ApplicationBackground.Instance);
                }
            }
         
        }
    }
}
