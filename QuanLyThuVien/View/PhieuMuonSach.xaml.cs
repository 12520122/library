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
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for PhieuMuonSach.xaml
    /// </summary>
    public partial class PhieuMuonSach : Window
    {
        public PhieuMuonSach()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn đã chắc chắn?", "Câu hỏi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
                this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có muốn in phiếu mượn không ? ", "Thong báo !", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    
                    List<string> List = new List<string>();
                    List.Add("Mã độc giả : " + MaDocGia.Text);
                    List.Add("Họ tên : " + HoTen.Text);
                    List.Add("Loại độc giả : " + LoaiDocGia.Text);
                    List.Add("Ngày sinh : " + NgaySinh.Text);
                    List.Add("Dịa chỉ : " + DiaChi.Text);
                    List.Add("Email : " + Email.Text);
                    List.Add("Ngày hết hạn : " + NgayHetHan.Text);
                    List.Add("Mã sách : " + MaSach.Text);
                    List.Add("Tên sách : " + TenSach.Text);
                    List.Add("Ngày mượn : " + NgayMuon.Text);
                    List.Add("Số sách mượn : " + SoSachChoMuon.Text);
                    using(System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName.ToString() + ".txt"))
                    {
                        foreach (string st in List)
                        {

                            sw.WriteLine(st);
                        }
                        sw.Close();
                    }
                }
            }
        }

        private void NgayMuon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9 /]+");
            e.Handled = regex.IsMatch(e.Text);
        }



        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    TextBox textBox = sender as TextBox;
        //    using (var db = new QLTVContext())
        //    {
        //        foreach(DocGia dg in db.DocGias)
        //        {
        //            if(dg.MaDocGia.ToString() == textBox.Text.ToString())
        //            {

        //            }
        //        }
        //    }
        //}
    }
}
