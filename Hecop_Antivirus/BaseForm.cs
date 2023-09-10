using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            label1.Text = Text;
            TextChanged += Label1_TextChanged;
            pictureBox1.Image = Icon.ToBitmap();
            BackgroundImageChanged += PictureBox1_BackgroundImageChanged;
        }

        private void PictureBox1_BackgroundImageChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Icon.ToBitmap();
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.DimGray), 2), ClientRectangle);
            base.OnPaint(e);
        }
    }
}
