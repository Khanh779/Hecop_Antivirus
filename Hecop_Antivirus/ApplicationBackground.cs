using Hecop_Antivirus.TabPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Antivirus
{
   
    public class ApplicationBackground : ApplicationContext
    {

        public NotifyIcon notifyIcon;
        ContextMenuStrip CMS;

        static ApplicationBackground _instance = null;
        public static ApplicationBackground Instance
        {
            get
            {
                if (_instance == null) _instance = new ApplicationBackground();
                return _instance;
            }
        }

        public ApplicationBackground()
        {
            _instance = this;
            notifyIcon = new NotifyIcon();
            CMS = new ContextMenuStrip();
            CMS.LayoutStyle = ToolStripLayoutStyle.StackWithOverflow;
        
            CMS.RenderMode = ToolStripRenderMode.Professional;
            CMS.ShowImageMargin = false;
            CMS.Items.Add("Mở cửa sổ", null, OpenApp);
            CMS.Items.Add("Đóng ứng dụng", null, CloseApp);
            notifyIcon.Icon = Form1.Instance.Icon;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = Application.ProductName;
            notifyIcon.Text = Application.ProductName +" "+ (EnableProtect? Properties.Resources.notify_startprotection : Properties.Resources.notify_endproctetion);
            notifyIcon.ContextMenuStrip = CMS;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;

            ClamAVManager.Instance.MaxFileSize = Properties.Settings.Default.MaxFileSize;
            ClamAVManager.Instance.MaxScanSize = Properties.Settings.Default.MaxScanSize;
        }

      
        bool enableProtect = true;
        public bool EnableProtect
        {
            get { return enableProtect; }
            set
            {
                enableProtect = value;

                notifyIcon.Text = Application.ProductName + " " + (EnableProtect ? Properties.Resources.notify_startprotection : Properties.Resources.notify_endproctetion);

                HomeUC.Instance.label1.Text = enableProtect ? Properties.Resources.ProtectionEnabled : Properties.Resources.ProtectionDisabled;

                HomeUC.Instance.pictureBox1.Image = enableProtect? Properties.Resources.security__6_: Properties.Resources.shield__1_;

                HomeUC.Instance.label1.ForeColor = enableProtect ? Color.FromArgb(62, 173, 182) : Color.FromArgb(224, 60, 59);

                if (enableProtect)
                {
                    AddWatcher();
                    if (fileSystemWatchers.Count != 0)
                    {
                        foreach (var a in fileSystemWatchers)
                        {
                         
                            a.EnableRaisingEvents = true;
                        }
                    }
              

                }
                else
                {
                    if (fileSystemWatchers.Count != 0)
                        foreach (var a in fileSystemWatchers)
                        {
                         
                            a.EnableRaisingEvents = false;
                            fileSystemWatchers.Clear();
                        }

                }
            }
        }

        List<FileSystemWatcher> fileSystemWatchers = new List<FileSystemWatcher>();

        public string Extentions = "*.*";


        public void AddWatcher()
        {
            foreach (var b in Directory.GetLogicalDrives())
            {
                DriveInfo DI = new DriveInfo(b);
                if (DI.IsReady)
                {
                    FileSystemWatcher watcher = new FileSystemWatcher(b);
                    watcher.Filter = Extentions; watcher.IncludeSubdirectories = true;
                    watcher.EnableRaisingEvents = true;
                    watcher.InternalBufferSize = Convert.ToInt32( Properties.Settings.Default.MaxFileSize);
                    watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

                    watcher.Deleted += (sender, e) =>
                    {
                        RealTimeScan(e.FullPath);
                    };

                    watcher.Error += (sender, e) =>
                    {
                      
                        Debug.WriteLine(e.ToString());
                    };

                    watcher.Changed += (sender, e) =>
                    {
                        RealTimeScan(e.FullPath);
                    };

                    watcher.Created += (sender, e) =>
                    {
                        RealTimeScan(e.FullPath);
                    };

                    watcher.Renamed += (sender, e) =>
                    {
                        RealTimeScan(e.FullPath);
                    };

                    fileSystemWatchers.Add(watcher);
                }
            }
        }

        void RealTimeScan(string filePath)
        {
            foreach (var a in fileSystemWatchers)
                a.Filter = Extentions;

            string virusName = ""; string fn = "";
            try
            {
                fn = new FileInfo(filePath).Name;
            }
            catch
            {
                fn = "error NA";
            }
            ProtectUC.Instance.label7.BeginInvoke((Action)delegate
            {
                ProtectUC.Instance.label7.Text = "Đang quét: " + fn;
            });
            try
            {
                long v = new FileInfo(filePath).Length;
                if (v<=(long)Properties.Settings.Default.MaxScanSize&& 
                    v<=(long)Properties.Settings.Default.MaxFileSize)

                if(ClamAVManager.Instance.ScanFileWithResult(filePath, ref virusName) == ClamAV_Lib.UnsafeNativeMethods.cl_error_t.CL_VIRUS)
                {
                    var a = new AlertRealTime();
                    a.Show(AlertRealTime.Type.Safe, filePath, ref virusName);
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }


        void OpenApp(object ob, EventArgs e)
        {
            Form1.Instance.Show();
        }

        void CloseApp(object ob, EventArgs e)
        {
            Application.ExitThread(); // Dừng mọi luồng mà ứng dụng thực thi
            Application.Exit(); // Đóng ứng dụng
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form1.Instance.Show();
            }
        }
    }
}
