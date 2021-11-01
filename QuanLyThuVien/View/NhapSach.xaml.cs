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

namespace QuanLyThuVien.Screens
{
    /// <summary>
    /// Interaction logic for NhapSach.xaml
    /// </summary>
    public partial class NhapSach : Window
    {
        public NhapSach()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn đã chắc chắn?", "Câu hỏi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                this.Close();
        }
        // ham rang buoc ky tu nhap
        private void btThemTheLoai_Click(object sender, RoutedEventArgs e)
        {
            var theloaisachWindow = new TheLoaiSach();
            theloaisachWindow.Show();
        }

        private void btThemTacGia_Click(object sender, RoutedEventArgs e)
        {
            var tacgiaWindow = new TheTacGia();
            tacgiaWindow.Show();
        }

        private void SoLuong_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void DonGia_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
