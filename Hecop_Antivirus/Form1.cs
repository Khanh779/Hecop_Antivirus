using Bunifu.Framework.UI;
using Hecop_Antivirus.TabPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus
{
    public partial class Form1 : Form
    {
        static Form1 _instance = null;
        /// <summary>
        /// Cho Form này chỉ hiển thị 1 cái duy nhất
        /// </summary>
        public static Form1 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new Form1();
                _instance.BringToFront(); // Đem nó ra trước
                return _instance;
            }
        }


        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.UserPaint| ControlStyles.OptimizedDoubleBuffer, true);
            if (!Directory.Exists(Application.StartupPath + "\\Quarantine\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Quarantine\\");
            }

            if (!Directory.Exists(Application.StartupPath + "\\DB\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\DB\\");
            }

            _instance = this;
            pictureBox1.Image = Icon.ToBitmap();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PN_Tab.Controls.Clear();
            ChangeTab(HomeUC.Instance);
        }

        /// <summary>
        /// Hàm thay đổi trang thẻ
        /// </summary>
        /// <param name="uc">User control em thay nó làm tab (Giả bộ)</param>
        public void ChangeTab(UserControl uc)
        {
                if(!PN_Tab.Contains(uc))
                {
                    PN_Tab.Controls.Clear();
                    PN_Tab.Controls.Add(uc);
                }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.DimGray), 2), ClientRectangle);
            base.OnPaint(e);
        }

        private void bunifuImageButton1_MouseClick(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Left) Instance.Hide();
        }

        private void bunifuImageButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized;
          
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Location = new Point(bunifuGradientPanel1.Location.X, bunifuTileButton1.Location.Y);
            ChangeTab(HomeUC.Instance);
            
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Location = new Point(bunifuGradientPanel1.Location.X, bunifuTileButton2.Location.Y);
            ChangeTab(ScanUC.Instance);

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Location = new Point(bunifuGradientPanel1.Location.X, bunifuTileButton3.Location.Y);
            ChangeTab(ProtectUC.Instance);
          
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Location = new Point(bunifuGradientPanel1.Location.X, bunifuTileButton4.Location.Y);
            ChangeTab(QuarantineUC.Instance);
           
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Location = new Point(bunifuGradientPanel1.Location.X, bunifuTileButton5.Location.Y);
            ChangeTab(SettingsUC.Instance);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

       
    }
}
