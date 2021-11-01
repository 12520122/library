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
    /// Interaction logic for TheDaoHanTheDocGia.xaml
    /// </summary>
    public partial class TheDaoHanTheDocGia : Window
    {
        public TheDaoHanTheDocGia()
        {
            InitializeComponent();
        }
        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
