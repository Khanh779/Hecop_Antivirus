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
    public partial class ProtectUC : UserControl
    {

        static ProtectUC _instance = null;
        public static ProtectUC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ProtectUC();
                return _instance;
            }
        }
        public ProtectUC()
        {
            InitializeComponent();_instance = this;
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            label3.Text = bunifuToggleSwitch1.Checked ? Properties.Resources.state_On : Properties.Resources.state_Off;
            ApplicationBackground.Instance.EnableProtect = bunifuToggleSwitch1.Checked;
         
        }

        private void bunifuToggleSwitch2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            label4.Text = bunifuToggleSwitch2.Checked ? Properties.Resources.state_On : Properties.Resources.state_Off;
        }
    }
}
