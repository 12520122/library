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
    public class KetNoiDbViewModel : ViewModelBase
    {
        private string _user;
        public string User
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    OnPropertyChanged("User");
                }
            }
        }
        private string _pass;
        public string Pass
        {
            get { return _pass; }
            set
            {
                if (_pass != value)
                {
                    _pass = value;
                    OnPropertyChanged("Pass");
                }
            }
        }
        public static String Cnn; //Chuoi ket noi
        private ICommand _ketnoiCmd;
        public ICommand KetnoiCmd
        {
            get { return _ketnoiCmd; }
            set { _ketnoiCmd = value; }
        }

        private ICommand _ketnoiOnlineCmd;
        public ICommand KetnoiOnlineCmd
        {
            get { return _ketnoiOnlineCmd; }
            set { _ketnoiOnlineCmd = value; }
        }
        private String databaseName = "QuanLyThuVien_QLTVContext";
        public static String nameServer;

        private string mk;

        public string Mk
        {
            get { return mk; }
            set
            {
                if (mk != value)
                {
                    mk = value;
                    OnPropertyChanged("Mk");
                }
            }
        }
        public KetNoiDbViewModel()
        {
            KetnoiCmd = new RelayCommand(new Action<object>(ketnoiCmd_Xuly));
            KetnoiOnlineCmd = new RelayCommand(new Action<object>(ketnoiOnlineCmd_Xuly));
        }

        private void ketnoiCmd_Xuly(object obj)
        {
            nameServer = obj.ToString();
            if (kiemtraTontaiCSDL(nameServer))
            {
                MessageBox.Show("database exists!");
            }
            else
            {
                restore(nameServer, Application.StartupPath, databaseName);
            }
            Cnn = "Data Source= " + nameServer
                   + ";Initial Catalog= " + databaseName
                   + ";Integrated Security=" + "True";
        }

        private void ketnoiOnlineCmd_Xuly(object obj)
        {
            nameServer = obj.ToString();
            Cnn = "Data Source= " + nameServer
                   + ";Database= " + databaseName
                   + ";User Id=" + User
                   + ";password=" + Pass;
        }
        private bool kiemtraTontaiCSDL(String nameserver)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            string cnStr = "Server=" + nameserver
                + ";Initial Catalog=" + "master"
                + ";Integrated Security =" + "True";

            SqlConnection cnn = new SqlConnection(cnStr);
            cnn.Open();
            String query = "SELECT name FROM sys.sysdatabases";
            cmd = new SqlCommand(query, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == databaseName)
                {
                    cnn.Close();
                    return true;
                }
            }

            return false;
        }
        private void backup()
        {

        }
        private void restore(String nameserver, String filePath, String databaseName)
        {
            SqlCommand cmd;
            string cnStr = "Server=" + nameserver
                            + ";Initial Catalog=" + "master"
                            + ";Integrated Security =" + "True";

            SqlConnection cnn = new SqlConnection(cnStr);
            cnn.Open();


            cmd = new SqlCommand("use master", cnn);
            cmd.ExecuteNonQuery();
            //string que = "RESTORE FILELISTONLY FROM DISK =" + "'" + filePath + "\\" + databaseName + ".bak" + "'";
            //cmd = new SqlCommand(que, cnn);
            //cmd.ExecuteNonQuery();
            string query = "RESTORE FILELISTONLY FROM DISK =" + "'" + filePath + "\\" + databaseName + ".bak" + "'"
                           + " ; "
                           + "RESTORE DATABASE " + "QuanLyThuVien_QLTVContext"
                           + " FROM DISK=" + "'" + filePath + "\\" + databaseName + ".bak" + "'"
                           + " WITH MOVE " + "'" + databaseName + "'" + " TO " + "'" + filePath + "\\" + databaseName + ".mdf" + "'"
                           + ", MOVE " + "'" + databaseName + "_log" + "'" + " TO " + "'" + filePath + "\\" + databaseName + "_log" + ".ldf" + "'";
            cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("restored database!");
        }
    }
}