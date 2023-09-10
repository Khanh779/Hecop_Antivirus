using Hecop_Antivirus.ExControls;

namespace Hecop_Antivirus.TabPages
{
    partial class QuarantineUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuarantineUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Hecop_Antivirus.ExControls.ExDataGridView();
            this.CH_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_VirusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 8;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton21.AutoSize = true;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Xóa";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton21.Location = new System.Drawing.Point(586, 406);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(100, 42);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 2;
            this.bunifuThinButton22.ActiveCornerRadius = 8;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton22.AutoSize = true;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Khôi phục";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 5;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton22.Location = new System.Drawing.Point(478, 406);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(100, 42);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 2;
            this.bunifuThinButton23.ActiveCornerRadius = 8;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton23.AutoSize = true;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Xóa tất cả";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 5;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton23.Location = new System.Drawing.Point(694, 406);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(100, 42);
            this.bunifuThinButton23.TabIndex = 8;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(18, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Có 0 mục cách ly";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Khu vực cách ly virus trong phần mềm chống virus ngăn chặn và xử lý các đe dọa độ" +
    "c hại bằng cách cô lập chúng, không gây hại cho hệ thống chính.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(746, 171);
            this.label3.TabIndex = 11;
            this.label3.Text = "Không có mục nào ở đây";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 2;
            this.bunifuThinButton24.ActiveCornerRadius = 8;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.LightGray;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton24.AutoSize = true;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Thêm tệp tin";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 5;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.Gainsboro;
            this.bunifuThinButton24.Location = new System.Drawing.Point(370, 406);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(100, 42);
            this.bunifuThinButton24.TabIndex = 12;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Mọi tệp | *.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Chọn tệp tin để thêm";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(777, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhấn và giữ phím Ctrl + click chuột để chọn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CH_FileName,
            this.CH_FilePath,
            this.CH_VirusName,
            this.CH_DateTime,
            this.CH_FileSize,
            this.CH_Dep});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.dataGridView1.Location = new System.Drawing.Point(20, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(72)))), ((int)(((byte)(81)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(774, 268);
            this.dataGridView1.TabIndex = 5;
            // 
            // CH_FileName
            // 
            this.CH_FileName.FillWeight = 113.9086F;
            this.CH_FileName.HeaderText = "Na";
            this.CH_FileName.Name = "CH_FileName";
            this.CH_FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CH_FilePath
            // 
            this.CH_FilePath.FillWeight = 113.9086F;
            this.CH_FilePath.HeaderText = "Đường dẫn";
            this.CH_FilePath.Name = "CH_FilePath";
            // 
            // CH_VirusName
            // 
            this.CH_VirusName.FillWeight = 113.9086F;
            this.CH_VirusName.HeaderText = "Tên virus";
            this.CH_VirusName.Name = "CH_VirusName";
            // 
            // CH_DateTime
            // 
            this.CH_DateTime.FillWeight = 113.9086F;
            this.CH_DateTime.HeaderText = "Thời gian";
            this.CH_DateTime.Name = "CH_DateTime";
            // 
            // CH_FileSize
            // 
            this.CH_FileSize.FillWeight = 113.9086F;
            this.CH_FileSize.HeaderText = "Kích cỡ";
            this.CH_FileSize.Name = "CH_FileSize";
            // 
            // CH_Dep
            // 
            this.CH_Dep.HeaderText = "Dep";
            this.CH_Dep.Name = "CH_Dep";
            this.CH_Dep.Visible = false;
            // 
            // QuarantineUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuarantineUC";
            this.Size = new System.Drawing.Size(826, 534);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ExDataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_VirusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Dep;
    }
}
