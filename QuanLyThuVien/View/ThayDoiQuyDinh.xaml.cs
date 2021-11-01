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

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for ThayDoiQuyDinh.xaml
    /// </summary>
    public partial class ThayDoiQuyDinh : Window
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btLoaiSach_Click(object sender, RoutedEventArgs e)
        {
            var loaisachWindow = new TheLoaiSach();
            loaisachWindow.Show();
        }

        private void btLoaiDocGia_Click(object sender, RoutedEventArgs e)
        {
            var loaidocgiaWindow = new Screens.LoaiDocGia();
            loaidocgiaWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn đã chắc chắn?", "Câu hỏi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                this.Close();
        }
        // ham rang buoc ky tu nhap
        private void DotuoiToiThieu_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!char.IsDigit(e.Text,e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void DotuoiToiDa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void ThoiHanThe_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void ThoiHanXuatBan_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void SachMuonToiDa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void NgayMuonToiDa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
