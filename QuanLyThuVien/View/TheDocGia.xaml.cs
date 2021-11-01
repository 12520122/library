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
    /// Interaction logic for TheDocGia.xaml
    /// </summary>
    public partial class TheDocGia : Window
    {
        public TheDocGia()
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
        private void dateNgaySinh_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        // ham rang buoc ky tu nhap
        private void dateNgayLapThe_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        //private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // ... Get DatePicker reference.
        //    var picker = sender as DatePicker;

        //    // ... Get nullable DateTime from SelectedDate.
        //    DateTime? date = picker.SelectedDate;
        //    if (date == null)
        //    {
        //        // ... A null object.
        //        this.Title = "No date";
        //    }
        //    else
        //    {
        //        // ... No need to display the time.
        //        this.Title = date.Value.ToShortDateString();
        //    }
        //}
    }
}
