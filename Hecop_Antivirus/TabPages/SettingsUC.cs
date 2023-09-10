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
    public partial class SettingsUC : UserControl
    {

        static SettingsUC _instance = null;
        public static SettingsUC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new SettingsUC();
                return _instance;
            }
        }

        public SettingsUC()
        {
            InitializeComponent(); _instance = this;
        }

      
    }
}
