using ClamAV_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using static ClamAV_Lib.UnsafeNativeMethods;

namespace Hecop_Antivirus
{
    public class ClamAVManager
    {
        static ClamAVManager _instance = null;
        public static ClamAVManager Instance
        {
            get
            {
                if (_instance == null) _instance = new ClamAVManager();
                return _instance;
            }
        }

        public ClamAVManager()
        {
            ce = new ClamEngine();
            MaxFileSize = MaxScanSize = 1024 ^3;
            _instance = this;
            
        }

        public string Version
        {
            get { return ce.Version; }
        }


        public int ScanFile(string file, ref string virusName)
        {
            int a = 0;
            try
            {
                a = ce.ScanFile(file, out virusName);
            }
            catch { a = 0; }

            return a;
        }

        public cl_error_t ScanFileWithResult(string file, ref string virusName)
        {
            return (cl_error_t)ScanFile(file, ref virusName);
        }

        public ulong MaxFileSize
        {
            get { return ce.MaxFileSize; }
            set
            {
                ce.MaxFileSize = value;
            }
        }

        public ulong MaxScanSize
        {
            get { return ce.MaxScanSize; }
            set
            {
                ce.MaxScanSize = value;
            }
        }


        private string connectionString = String.Format("Data Source = {0}; Version = 3;", Application.StartupPath+"\\VirusDat.db");
     
        public void AddItem(VirusData virusData)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS VirusData (FileName TEXT, FilePath TEXT, VirusName TEXT, FileSize TEXT, DateTime TEXT, Dep TEXT);";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string insertDataQuery = "INSERT INTO VirusData (FileName, FilePath, VirusName, FileSize, DateTime, Dep) VALUES (@FileName, @FilePath, @VirusName, @FileSize, @DateTime, @Dep);";
                using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                {
                    var file = virusData;
                    command.Parameters.AddWithValue("@FileName", file.FileName);
                    command.Parameters.AddWithValue("@FilePath", file.FilePath);
                    command.Parameters.AddWithValue("@VirusName", file.VirusName);
                    command.Parameters.AddWithValue("@DateTime", file.DateTime);
                    command.Parameters.AddWithValue("@FileSize", file.FileSize);
                    command.Parameters.AddWithValue("@Dep", file.Dep);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteItem(VirusData virusData, string deleteItem)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = $"DELETE FROM VirusData WHERE Dep = @{deleteItem};";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue($"@{deleteItem}", deleteItem);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateFileWithVirus(VirusData Item)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
               
                string updateQuery = "UPDATE VirusData SET VirusName = @VirusName, FilePath = @FilePath, FileSize = @FileSize, DateTime = @DateTime WHERE FileName = @FileName;";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@FileName", Item.FileName);
                    command.Parameters.AddWithValue("@FilePath", Item.FileName);
                    command.Parameters.AddWithValue("@VirusName", Item.VirusName);
                    command.Parameters.AddWithValue("@DateTime", Item.DateTime);
                    command.Parameters.AddWithValue("@FileSize", Item.FileSize);

                    command.ExecuteNonQuery();
                }
            }
        }

        internal string password = "Bkav123*";

        public void MoveToQuarantine(VirusData virusData)
        {
            virusData.Dep = DateTime.Now.ToString().Replace(" ", "p").Replace("/", "x").Replace(":", "d") + "v" + DateTime.Now.Millisecond.ToString();
            string desti = Application.StartupPath + "\\Quarantine\\" + virusData.Dep;
            var a = new System.IO.FileInfo(virusData.FilePath  + virusData.FileName);
           
            try
            {
                AESCrypt.EncryptFile(a.FullName, desti, password);
            }
            catch { }
            ClamAVManager.Instance.AddItem(virusData);
        }

        public void RestoreFromQuarantine(VirusData virusData, string item)
        {
            var a = new System.IO.FileInfo(virusData.FilePath + virusData.FileName);
            try
            {
                AESCrypt.DecryptFile(virusData.FilePath+"\\"+ item+ ".hevir", a.FullName, password);
            }
            catch { }

            ClamAVManager.Instance.DeleteItem(virusData, item);
        }

 
        public List<VirusData> GetVirusData()
        {
            List<VirusData> filesWithVirus = new List<VirusData>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT FileName, FilePath,  VirusName, DateTime, FileSize, Dep FROM VirusData;";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VirusData file = new VirusData
                            {
                                FileName = reader["FileName"].ToString(),
                                FilePath = reader["FilePath"].ToString(),
                                VirusName = reader["VirusName"].ToString(),
                                DateTime = (reader["DateTime"]).ToString(),
                                FileSize = Convert.ToInt64(reader["FileSize"]),
                                Dep= (reader["Dep"]).ToString()
                            };

                            filesWithVirus.Add(file);
                        }
                    }
                }
            }

            return filesWithVirus;
        }

        ClamEngine ce;

        public List<VirusData> VirusDataList = new List<VirusData>();
        public void ClearVirusDataList()
        {
            VirusDataList.Clear();
        }

        public struct VirusData
        {
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string VirusName { get; set; }
            public string DateTime { get; set; }
            public long FileSize { get; set; }
            public string Dep { get;set; }

        }

    }
}
