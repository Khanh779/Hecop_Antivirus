using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus.ExControls
{
    public partial class SubTitleButton : UserControl
    {
        public SubTitleButton()
        {
            InitializeComponent();

            MouseLeave += SubTitleButton_MouseLeave;
            MouseDown += SubTitleButton_MouseDown;
            MouseEnter += SubTitleButton_MouseEnter;
            MouseUp += SubTitleButton_MouseUp;
         

            pictureBox1.MouseUp += SubTitleButton_MouseUp1;
            pictureBox1.MouseLeave += SubTitleButton_MouseLeave1;
            pictureBox1.MouseDown += SubTitleButton_MouseDown1;
            pictureBox1.MouseEnter += SubTitleButton_MouseEnter1;
            pictureBox1.Click += SubTitleButton_Click1;
            pictureBox1.MouseClick += SubTitleButton_MouseClick1;

            label1.MouseUp += SubTitleButton_MouseUp1;
            label1.MouseLeave += SubTitleButton_MouseLeave1;
            label1.MouseDown += SubTitleButton_MouseDown1;
            label1.MouseEnter += SubTitleButton_MouseEnter1;
            label1.Click += SubTitleButton_Click1;
            label1.MouseClick += SubTitleButton_MouseClick1;

            label2.MouseUp += SubTitleButton_MouseUp1;
            label2.MouseLeave += SubTitleButton_MouseLeave1;
            label2.MouseDown += SubTitleButton_MouseDown1;
            label2.MouseEnter += SubTitleButton_MouseEnter1;
            label2.Click += SubTitleButton_Click1;
            label2.MouseClick += SubTitleButton_MouseClick1;

            bunifuCircleProgress2.MouseUp += SubTitleButton_MouseUp1;
            bunifuCircleProgress2.MouseLeave += SubTitleButton_MouseLeave1;
            bunifuCircleProgress2.MouseDown += SubTitleButton_MouseDown1;
            bunifuCircleProgress2.MouseEnter += SubTitleButton_MouseEnter1;
            bunifuCircleProgress2.Click += SubTitleButton_Click1;
            bunifuCircleProgress2.MouseClick += SubTitleButton_MouseClick1;

        }

        public bool IsLoading
        {
            get { return bunifuCircleProgress2.Visible; }
            set
            {
                bunifuCircleProgress2.Visible = value;
            }
        }

        public string TitleText
        {
            get {return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }

        public string SubTitleText
        {
            get { return label2.Text; }
            set
            {
                label2.Text = value;
            }
        }

        public Image Image
        {
            get { return pictureBox1.Image; }
            set
            {
                pictureBox1.Image = value;
            }
        }


       
        private void SubTitleButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = btnColor;
            //base.OnMouseUp(e);
        }

        private void SubTitleButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = hoverColor;
            //base.OnMouseEnter(e);
        }

        private void SubTitleButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = pressedColor;
            //base.OnMouseDown(e);
        }

        private void SubTitleButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = btnColor;
            //base.OnMouseLeave(e);
        }

        private void SubTitleButton_MouseClick1(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        private void SubTitleButton_Click1(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void SubTitleButton_MouseUp1(object sender, MouseEventArgs e)
        {
            //BackColor = btnColor;
            base.OnMouseUp(e);
        }

        private void SubTitleButton_MouseEnter1(object sender, EventArgs e)
        {
            
            base.OnMouseEnter(e);
        }

        private void SubTitleButton_MouseDown1(object sender, MouseEventArgs e)
        {
            
            base.OnMouseDown(e);
        }

        private void SubTitleButton_MouseLeave1(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        Color btnColor = Color.FromArgb(58, 62, 71);
        Color hoverColor = Color.FromArgb(68, 72, 81);
        Color pressedColor = Color.FromArgb(48, 52, 61);
        Color borderColor = Color.DimGray;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(borderColor), 2), ClientRectangle);
            base.OnPaint(e);
        }

       

    }
}
