using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCircleProgress.Transitions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hecop_Antivirus.TabPages
{
    public partial class ScanUC : UserControl
    {

        static ScanUC _instance = null;
        public static ScanUC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ScanUC();
                return _instance;
            }
        }

        public ScanUC()
        {
            InitializeComponent(); _instance = this;
            Load += ScanUC_Load;
        }

        private void ScanUC_Load(object sender, EventArgs e)
        {
        
        }

  

      
        private void bunifuButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              
                Thread run = new Thread(new ThreadStart(delegate
                {

                    bunifuButton1.Enabled = false;
                    label3.Text = "Trạng thái:\nĐang cập nhật...";
                    bunifuCircleProgress1.Invoke((Action)delegate
                    {
                        bunifuCircleProgress1.Visible = true; bunifuCircleProgress1.Animated = true;
                    });
                
                    Process proc = new Process();
                    proc.StartInfo.FileName = Application.StartupPath + "\\freshclam.exe";
                    //proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.EnableRaisingEvents = true;
                    proc.Start();
                    proc.WaitForExit();

                    bunifuButton1.Enabled = true;
                    bunifuCircleProgress1.Invoke((Action)delegate
                    {
                        bunifuCircleProgress1.Visible = false; bunifuCircleProgress1.Animated = false;
                    });
                    
                    label3.Text = "Trạng thái:\nCập nhật xong cơ sở dữ liệu...";
                }));
                run.IsBackground = true;
                run.Start();
            }
        }

    
    }
}
