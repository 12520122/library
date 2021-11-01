using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for PhieuThuTienPhat.xaml
    /// </summary>
    public partial class PhieuThuTienPhat : Window
    {
        public PhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        // ham rang buoc ky tu nhap
        private void NgayThu_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SoTienThu_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
