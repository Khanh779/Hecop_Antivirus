using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus.TabPages
{
    public partial class HomeUC : UserControl
    {
        static HomeUC _instance = null;
        public static HomeUC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new HomeUC();
                return _instance;
            }
        }

        public HomeUC()
        {
            InitializeComponent();
          _instance = this;
            label2.Text = "Phiên bản ClamAV: " + ClamAVManager.Instance.Version;
        }


        protected override void OnCreateControl()
        {
            panel1.Location = new Point(Width / 2 - panel1.Width / 2, 80);
            bunifuButton1.Location = new Point(bunifuButton1.Location.X, panel1.Location.Y + panel1.Height + 2);
            base.OnCreateControl();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form1.Instance.ChangeTab(ScanUC.Instance);
            Form1.Instance.bunifuGradientPanel1.Location = new Point(Form1.Instance.bunifuGradientPanel1.Location.X, Form1.Instance.bunifuTileButton2.Location.Y);
        }
    }
}
