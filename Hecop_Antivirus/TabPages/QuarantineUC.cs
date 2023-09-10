using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hecop_Antivirus.ClamAVManager;

namespace Hecop_Antivirus.TabPages
{
    public partial class QuarantineUC : UserControl
    {
        static QuarantineUC _instance = null;
        public static QuarantineUC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new QuarantineUC();
                return _instance;
            }
        }

        public QuarantineUC()
        {
            InitializeComponent();_instance = this;
            dataGridView1.RowsAdded += DataGridView1_RowsAdded; dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            Load += QuarantineUC_Load;
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.RowCount > 0) label3.Visible = false;
            label2.Text = String.Format("Có {0} mục đã được cách ly", dataGridView1.RowCount);
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.RowCount > 0) label3.Visible = false;
            label2.Text = String.Format("Có {0} mục đã được cách ly", dataGridView1.RowCount);
        }

        private void QuarantineUC_Load(object sender, EventArgs e)
        {
            LoadVirusList();

        }

        public void LoadVirusList()
        {
            dataGridView1.Invoke((Action)(() =>
            {
                dataGridView1.Rows.Clear();
                if (new System.IO.FileInfo(Application.StartupPath + "\\VirusDat.db").Exists)
                    foreach (var a in ClamAVManager.Instance.GetVirusData())
                    {
                        dataGridView1.Rows.Add(new string[] { a.FileName, a.FilePath, a.VirusName, a.DateTime, a.FileSize + " KB", a.Dep });
                    }
            }));
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                VirusData VD = new VirusData();
                MessageBox.Show(openFileDialog1.FileName);
                var a = new System.IO.FileInfo(openFileDialog1.FileName);
                VD.FileName = a.Name;

                VD.FilePath = a.Directory.FullName;
                VD.VirusName = "Malware-Type:GEN";
                VD.DateTime = DateTime.Now.ToShortDateString();
                VD.FileSize = a.Length / (1024);
                var v = new Thread(new ThreadStart( delegate
                {
                    BeginInvoke((Action)(() => ClamAVManager.Instance.MoveToQuarantine(VD)));
                    MessageBox.Show("Đã khôi phục tệp tin đã chọn", Application.ProductName);
                    LoadVirusList();
                }));
                v.IsBackground=true;v.Start();
                
            }
          
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridView1.SelectedRows)
            {
                VirusData VD = new VirusData();
                VD.Dep = (string)a.Cells[5].FormattedValue;
                var v = new Thread(new ThreadStart(delegate
                {
                    System.IO.File.Delete(Application.StartupPath + "\\Quarantine\\" + VD.Dep + ".hevir");
                    BeginInvoke((Action)(() => {
                        
                        ClamAVManager.Instance.RestoreFromQuarantine(VD, VD.Dep);
                        }));
                    MessageBox.Show("Đã khôi phục các tệp tin đã chọn", Application.ProductName);
                    LoadVirusList();
                }));
                v.IsBackground = true; v.Start();

            }
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridView1.SelectedRows)
            {
                VirusData VD = new VirusData();
                VD.Dep = (string)a.Cells[5].FormattedValue;
                var v = new Thread(new ThreadStart(delegate
                {
                    MessageBox.Show("A");
                    try
                    {
                        System.IO.File.Delete(Application.StartupPath + "\\Quarantine\\" + VD.Dep + ".hevir");
                        BeginInvoke((Action)(() => ClamAVManager.Instance.DeleteItem(VD, VD.Dep)));
                        MessageBox.Show("Đã xóa các tệp tin đã chọn", Application.ProductName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                  
                    LoadVirusList();
                }));
                v.IsBackground = true; v.Start();
              
            }
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dataGridView1.Rows)
            {
                VirusData VD = new VirusData();
                VD.Dep = (string)a.Cells[5].FormattedValue;
                var v = new Thread(new ThreadStart(delegate
                {
                    try
                    {
                        System.IO.File.Delete(Application.StartupPath + "\\Quarantine\\" + VD.Dep + ".hevir");
                        BeginInvoke((Action)(() => ClamAVManager.Instance.DeleteItem(VD, VD.Dep)));
                        MessageBox.Show("Đã xóa tất cả tệp tin", Application.ProductName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    LoadVirusList();
                }));
                v.IsBackground = true; v.Start();

            }
           
        }
    }
}
