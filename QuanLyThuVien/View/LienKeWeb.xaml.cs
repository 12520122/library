using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyThuVien.View
{
    /// <summary>
    /// Interaction logic for LienKeWeb.xaml
    /// </summary>
    public partial class LienKeWeb : Window
    {
        public LienKeWeb()
        {
            InitializeComponent();
            ListWeb.Items.Add("Thư viện trung tâm");
            ListWeb.Items.Add("Thư viện trường ĐH Bách Khoa");
            ListWeb.Items.Add("Thư viện trường ĐH Công Nghệ Thông Tin");
            ListWeb.Items.Add("Thư viện trường ĐH Khoa Học Xã Hội và Nhân Văn");
            ListWeb.Items.Add("Thư viện trường ĐH Nông Lâm");
            ListWeb.Items.Add("Thư viện trường ĐH Khoa Học Tự Nhiên");
            ListWeb.Items.Add("Thư viện trường ĐH Kinh Tế - Luật");
            ListWeb.SelectedItem = ListWeb.Items[0];
        }

        private void XacNhan_Click(object sender, RoutedEventArgs e)
        {
            if(ListWeb.SelectedItem == ListWeb.Items[0])
            {
                System.Diagnostics.Process.Start("http://www.vnulib.edu.vn/#1");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[1])
            {
                System.Diagnostics.Process.Start("http://www.lib.hcmut.edu.vn/");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[2])
            {
                System.Diagnostics.Process.Start("http://thuvien.uit.edu.vn/");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[3])
            {
                System.Diagnostics.Process.Start("http://lib.hcmussh.edu.vn/");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[4])
            {
                System.Diagnostics.Process.Start("http://elib.hcmuaf.edu.vn/");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[5])
            {
                System.Diagnostics.Process.Start("http://gralib.hcmuns.edu.vn/opac/simpleSearch_khtn_index.jsp");
            }
            else if (ListWeb.SelectedItem == ListWeb.Items[6])
            {
                System.Diagnostics.Process.Start("http://www.uel.edu.vn/TopicId/100014a5-ffb7-4870-8057-9c5adeb9feda/ban-tin");
            }
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
