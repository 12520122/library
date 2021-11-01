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
    /// Interaction logic for BaoCaoTKSachTraTre.xaml
    /// </summary>
    public partial class BaoCaoTKSachTraTre : Window
    {
        public BaoCaoTKSachTraTre()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // Ham tao may ao in
        private void In_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                // sizing of the element.
                DataGridBC.Measure(pageSize);
                DataGridBC.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printdlg.PrintVisual(DataGridBC, Title);
                MessageBox.Show("In thành công !", "Thông báo !");
            }
        }
        // ham rang buoc ky tu nhap
        private void NgayBaoCao_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
