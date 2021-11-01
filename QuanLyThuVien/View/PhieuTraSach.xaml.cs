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
    /// Interaction logic for PhieuTraSach.xaml
    /// </summary>
    public partial class PhieuTraSach : Window
    {
        public PhieuTraSach()
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
        private void NgayTra_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
