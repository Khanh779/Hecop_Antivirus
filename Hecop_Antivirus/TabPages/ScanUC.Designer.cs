namespace Hecop_Antivirus.TabPages
{
    partial class ScanUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanUC));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.subTitleButton3 = new Hecop_Antivirus.ExControls.SubTitleButton();
            this.subTitleButton2 = new Hecop_Antivirus.ExControls.SubTitleButton();
            this.subTitleButton1 = new Hecop_Antivirus.ExControls.SubTitleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 26);
            this.tabControl1.Location = new System.Drawing.Point(17, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.subTitleButton3);
            this.tabPage1.Controls.Add(this.subTitleButton2);
            this.tabPage1.Controls.Add(this.subTitleButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quét";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn chế độ quét virus\r\nLời khuyên: Bạn nên cập nhật cơ sở dữ liệu trước khi quét" +
    " virus.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.bunifuButton1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bunifuCircleProgress1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cập nhật";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 48);
            this.label3.TabIndex = 20;
            this.label3.Text = "Trạng thái:\r\nĐã cập nhật phiên bản";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 100;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Cập nhật";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuButton1.IdleBorderRadius = 31;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(641, 90);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(112, 33);
            this.bunifuButton1.TabIndex = 18;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuButton1_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lời khuyên: Nên cập nhật cơ sở dữ liệu virus ít nhất 1 tuần để có thể nhận diện đ" +
    "ược các mối đe dọa mới nhất.";
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = false;
            this.bunifuCircleProgress1.AnimationInterval = 2;
            this.bunifuCircleProgress1.AnimationSpeed = 10;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.IsPercentage = true;
            this.bunifuCircleProgress1.LineProgressThickness = 5;
            this.bunifuCircleProgress1.LineThickness = 2;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(305, 175);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.DimGray;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(151)))), ((int)(((byte)(50)))));
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Arrow;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(167, 167);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = "";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 40, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "%";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Visible = false;
            // 
            // subTitleButton3
            // 
            this.subTitleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subTitleButton3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleButton3.Image = ((System.Drawing.Image)(resources.GetObject("subTitleButton3.Image")));
            this.subTitleButton3.IsLoading = false;
            this.subTitleButton3.Location = new System.Drawing.Point(534, 98);
            this.subTitleButton3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.subTitleButton3.Name = "subTitleButton3";
            this.subTitleButton3.Size = new System.Drawing.Size(173, 164);
            this.subTitleButton3.SubTitleText = "Chọn thư mục hoặc ổ đĩa để quét virus";
            this.subTitleButton3.TabIndex = 2;
            this.subTitleButton3.TitleText = "Quét tùy chọn";
            // 
            // subTitleButton2
            // 
            this.subTitleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subTitleButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleButton2.Image = ((System.Drawing.Image)(resources.GetObject("subTitleButton2.Image")));
            this.subTitleButton2.IsLoading = false;
            this.subTitleButton2.Location = new System.Drawing.Point(305, 98);
            this.subTitleButton2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.subTitleButton2.Name = "subTitleButton2";
            this.subTitleButton2.Size = new System.Drawing.Size(173, 164);
            this.subTitleButton2.SubTitleText = "Quét toàn bộ ổ đĩa để phát hiện virus";
            this.subTitleButton2.TabIndex = 1;
            this.subTitleButton2.TitleText = "Quét toàn bộ";
            // 
            // subTitleButton1
            // 
            this.subTitleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subTitleButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleButton1.Image = ((System.Drawing.Image)(resources.GetObject("subTitleButton1.Image")));
            this.subTitleButton1.IsLoading = false;
            this.subTitleButton1.Location = new System.Drawing.Point(73, 98);
            this.subTitleButton1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.subTitleButton1.Name = "subTitleButton1";
            this.subTitleButton1.Size = new System.Drawing.Size(173, 164);
            this.subTitleButton1.SubTitleText = "Dữ liệu chương trình và vùng quan trọng hệ thống";
            this.subTitleButton1.TabIndex = 0;
            this.subTitleButton1.TitleText = "Quét nhanh";
            // 
            // ScanUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "ScanUC";
            this.Size = new System.Drawing.Size(826, 534);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ExControls.SubTitleButton subTitleButton1;
        private ExControls.SubTitleButton subTitleButton3;
        private ExControls.SubTitleButton subTitleButton2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label3;
    }
}
