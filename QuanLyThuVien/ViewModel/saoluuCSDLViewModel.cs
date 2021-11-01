using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public class saoluuCSDLViewModel : ViewModelBase
    {
        private string _lastBackup;
        private String databaseName = "QuanLyThuVien_QLTVContext";
        private string _NAMESERVER;
        private ICommand _saoluumoiCmd;

        public ICommand SaoluumoiCmd
        {
            get { return _saoluumoiCmd; }
            set { _saoluumoiCmd = value; }
        }
        public string NAMESERVER
        {
            get { return _NAMESERVER; }
            set 
            {
                if (_NAMESERVER != value)
                {
                    _NAMESERVER = value;
                    OnPropertyChanged("NAMESERVER");
                }
            }
        }
        public string LastBackup
        {
            get { return _lastBackup; }
            set 
            {
                if(_lastBackup != value)
                {
                    _lastBackup = value;
                    OnPropertyChanged("LastBackup");
                }
            }
        }
        public saoluuCSDLViewModel()
        {
            LastBackup = GetlastBackup(databaseName);
            NAMESERVER = KetNoiDbViewModel.nameServer;
            SaoluumoiCmd = new RelayCommand(new Action<object>(saoluumoiCmd_Xuly));
        }

        private void saoluumoiCmd_Xuly(object obj)
        {
            backup(_NAMESERVER, Application.StartupPath, databaseName);
            LastBackup = GetlastBackup(databaseName);
            MessageBox.Show("Đã sao lưu tới: " + Application.StartupPath);
        }
        private String GetlastBackup(String databasename)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            string cnStr = "Server=" + KetNoiDbViewModel.nameServer
                + ";Initial Catalog=" + "master"
                + ";Integrated Security =" + "True";

            SqlConnection cnn = new SqlConnection(cnStr);
            cnn.Open();
            String query = "SELECT Database_name, MAX(Backup_finish_date) AS 'latest Backup Date' FROM msdb..backupset GROUP BY database_name";
            cmd = new SqlCommand(query, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String sss = dr[0].ToString();
                String ss = dr[1].ToString();
                if (dr[0].ToString() == databasename)
                {
                    return dr[1].ToString();
                }
            }
            return null;
        }

        private void backup(String nameserver, String filePath, String databaseName)
        {
            SqlCommand cmd;
            string cnStr = "Server=" + KetNoiDbViewModel.nameServer
                            + ";Initial Catalog=" + "master"
                            + ";Integrated Security =" + "True";

            SqlConnection cnn = new SqlConnection(cnStr);
            cnn.Open();


            cmd = new SqlCommand("use master", cnn);
            cmd.ExecuteNonQuery();
            string query = "BACKUP DATABASE " + "QuanLyThuVien_QLTVContext "
                           + "TO DISK=" + "'" + filePath + "\\" + databaseName + ".bak" + "'" + " with init";
            cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
