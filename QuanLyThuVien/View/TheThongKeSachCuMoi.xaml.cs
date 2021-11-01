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
    /// Interaction logic for TheThongKeSachCuMoi.xaml
    /// </summary>
    public partial class TheThongKeSachCuMoi : Window
    {
        public TheThongKeSachCuMoi()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        // Ham khoi tao may in ao 
        private void In_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);
                // sizing of the element.
                DataThongKeSachCuMoi.Measure(pageSize);
                DataThongKeSachCuMoi.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printdlg.PrintVisual(DataThongKeSachCuMoi, Title);
                MessageBox.Show("In thành công !", "Thông báo !");
            }
        }
    }
}
