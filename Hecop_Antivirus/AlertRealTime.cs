using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hecop_Antivirus
{
    public partial class AlertRealTime : Hecop_Antivirus.BaseForm
    {
        public AlertRealTime()
        {
            InitializeComponent();
        }

        public enum Type { Safe, Warning, Error}


        public void Show(Type type, string fileName, ref string virusName)
        {
            System.IO.FileInfo FI = new System.IO.FileInfo(fileName);
            switch(type)
            {
                case Type.Safe:
                    pictureBox2.Image = Properties.Resources.icons8_safe_100__1_;
                    break;
                case Type.Warning:
                    pictureBox2.Image = Properties.Resources.icons8_warning_100;
                    break;
                case Type.Error:
                    pictureBox2.Image=Properties.Resources.icons8_error_100;
                    break;
            }
            label3.Text = "Tệp tin: " + FI.Name;
            label4.Text = "Đường dẫn: " + FI.Directory.FullName;
            label5.Text = "Tên virus: " + virusName;
            label6.Text = "Thời gian: " + DateTime.Now.ToString();
            base.Show();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1.Instance.ChangeTab(TabPages.QuarantineUC.Instance);
            Form1.Instance.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
