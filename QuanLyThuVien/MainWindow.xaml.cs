using QuanLyThuVien.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public delegate void Login(string username, string password);
        //public event Login LoginEvent;
        public MainWindow()
        {
            InitializeComponent();
            HamDangNhap(false, false);
            var ketnoiWindow = new KetNoiDb();
            ketnoiWindow.ShowDialog();
        }
        #region Hệ thống _ Click
        private void miHDSD_Click(object sender, RoutedEventArgs e)
        {
            //var huongdansudung = new TheHuongDanSuDung();
            //huongdansudung.Show();
            String assemblyPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            Process.Start(assemblyPath + "/Huongdansudung.pdf");
            //this.WindowState = WindowState.Minimized;
        }

        private void miThongTin_Click(object sender, RoutedEventArgs e)
        {
            string information = "NHÓM SINH VIÊN THỰC HIỆN:\n\n Cấn Hoàng Hải 12520122\n Bùi Ngọc Tài 12520365 \nLê Xuân Trường 12520473\n Trần Đức Vinh 12520514";
            MessageBox.Show(information);
        }

        private void miThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Menu - Click
        private void btAddDocGia_Click(object sender, RoutedEventArgs e)
        {
            var docGiaWindow = new TheDocGia();
            docGiaWindow.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void btNhapSach_Click(object sender, RoutedEventArgs e)
        {
            var nhapsachWindow = new Screens.NhapSach();
            nhapsachWindow.Show();
        }

        private void btTraCuu_Click(object sender, RoutedEventArgs e)
        {
            var tracuuWindow = new DanhSachSach();
            tracuuWindow.Show();
        }

        private void btQuyDinh_Click(object sender, RoutedEventArgs e)
        {
            var quydinhWindow = new ThayDoiQuyDinh();
            quydinhWindow.Show();
        }

        private void miPhanQuyen_Click(object sender, RoutedEventArgs e)
        {
            var ThePhanQuyen = new ThePhanQuyen();
            ThePhanQuyen.Show();
        }

        private void miSaoLuuCSDL_Click(object sender, RoutedEventArgs e)
        {
            var SaoLuuCSDLWindow = new saoluuCSDL();
            SaoLuuCSDLWindow.Show();
        }

        private void btThoatMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Mượn trả - Click
        private void miTraCuu_Click(object sender, RoutedEventArgs e)
        {
            var tracuuWindow = new DanhSachSach();
            tracuuWindow.Show();
        }

        private void miMuonSach_Click(object sender, RoutedEventArgs e)
        {
            var muonsachWindow = new PhieuMuonSach();
            muonsachWindow.Show();

        }

        private void miTraSach_Click(object sender, RoutedEventArgs e)
        {
            var trasachWindow = new PhieuTraSach();
            trasachWindow.Show();
        }

        private void miThuTien_Click(object sender, RoutedEventArgs e)
        {
            var thutienWindow = new PhieuThuTienPhat();
            thutienWindow.Show();
        }
        #endregion

        #region Danh mục - Click
        private void miNhapSach_Click(object sender, RoutedEventArgs e)
        {
            var nhapsachWindow = new Screens.NhapSach();
            nhapsachWindow.Show();
        }

        private void miThemTacGia_Click(object sender, RoutedEventArgs e)
        {
            var tacgiaWindow = new Screens.TheTacGia();
            tacgiaWindow.Show();
        }

        private void miThemDocGia_Click(object sender, RoutedEventArgs e)
        {
            var docgiaWindow = new TheDocGia();
            docgiaWindow.Show();
        }

        private void miThemLoaiSach_Click(object sender, RoutedEventArgs e)
        {
            var loaisachWindow = new TheLoaiSach();
            loaisachWindow.Show();
        }

        private void miThemLoaiDocGia_Click(object sender, RoutedEventArgs e)
        {
            var loaidocgiaWindow = new Screens.LoaiDocGia();
            loaidocgiaWindow.Show();
        }

        private void miThayDoiQuyDinh_Click(object sender, RoutedEventArgs e)
        {
            var quydinhWindow = new ThayDoiQuyDinh();
            quydinhWindow.Show();
        }
        private void miGiaHanMuonSach_Click(object sender, RoutedEventArgs e)
        {
            var TheGiaHanMuonSach = new fmTheDaoHanMuonSach();
            TheGiaHanMuonSach.Show();
        }

        private void miDaoHanTheDocGia_Click(object sender, RoutedEventArgs e)
        {
            var DaoHanTheDocGia = new TheDaoHanTheDocGia();
            DaoHanTheDocGia.Show();
        }

        #endregion

        #region Báo cáo - Click
        private void miBCTheoTL_Click(object sender, RoutedEventArgs e)
        {
            var baocaotheoTLWindow = new Screens.BaoCaoTKMuonSachTTL();
            baocaotheoTLWindow.Show();
        }

        private void miBCSachTraTre_Click(object sender, RoutedEventArgs e)
        {
            var baocaosachtratreWindow = new BaoCaoTKSachTraTre();
            baocaosachtratreWindow.Show();
        }
        private void miTKSachCuMoi_Click(object sender, RoutedEventArgs e)
        {
            var ThongKeSachCuMoi = new TheThongKeSachCuMoi();
            ThongKeSachCuMoi.Show();
        }
        private void miDiemCacDauSach_Click(object sender, RoutedEventArgs e)
        {
            var DiemCacDauSach = new DiemCacDauSach();
            DiemCacDauSach.Show();
        }
        #endregion

        #region Phím tắt
        // Tao cac phim tat cho form chinh
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                miHDSD_Click(sender, e);
            }
            else if (e.Key == Key.F2)
            {
                miThongTin_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && (Keyboard.IsKeyDown(Key.D7) || Keyboard.IsKeyDown(Key.NumPad7)))
            {
                miTraCuu_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.T))
            {
                miTraSach_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.M))
            {
                miMuonSach_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.P))
            {
                miThuTien_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)) && Keyboard.IsKeyDown(Key.S))
            {
                btNhapSach_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)) && Keyboard.IsKeyDown(Key.T))
            {
                miThemTacGia_Click(sender, e);
            }
            else if ((Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)) && Keyboard.IsKeyDown(Key.D))
            {
                btAddDocGia_Click(sender, e);
            }
        }
        #endregion
      
        public void HamDangNhap(bool dn, bool quyen)
        {
            if(dn == true)
            {
                MenuMuonTra.IsEnabled = true;
                MenuDanhMuc.IsEnabled = true;
                MenuBaoCao.IsEnabled = true;
                btAddDocGia.IsEnabled = true;
                btTraCuu.IsEnabled = true;
                btNhapSach.IsEnabled = true;
                btQuyDinh.IsEnabled = true;
                DangNhap.IsEnabled = false;
                DangXuat.IsEnabled = true;
                TextTaiKhoan.Text = "";
                PassMatKhau.Password = "";
                PassMatKhau.IsEnabled = false;
                TextTaiKhoan.IsEnabled = false;
                miSaoLuuCSDL.IsEnabled = true;
                if(quyen == true)
                {
                    miPhanQuyen.IsEnabled = true;
                }
                else
                {
                    miPhanQuyen.IsEnabled = false;
                }
            }
            else
            {
                MenuMuonTra.IsEnabled = false;
                MenuDanhMuc.IsEnabled = false;
                MenuBaoCao.IsEnabled = false;
                btAddDocGia.IsEnabled = false;
                btTraCuu.IsEnabled = false;
                btNhapSach.IsEnabled = false;
                btQuyDinh.IsEnabled = false;
                miPhanQuyen.IsEnabled = false;
                DangNhap.IsEnabled = true;
                DangXuat.IsEnabled = false;
                TextTaiKhoan.IsEnabled = true;
                PassMatKhau.IsEnabled = true;
                miSaoLuuCSDL.IsEnabled = false;
            }
        }
        //Ham dang nhap khi thanh cong thi nguoi dung se su dung duoc cac chuc nang
        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            bool dangNhap = true;
            if (TextTaiKhoan.Text != "" || PassMatKhau.Password.ToString() != "")
            {
                using (var db = new QLTVContext())
                {
                    foreach (QuyenHan QH in db.QuyenHans.ToList())
                    {
                        if (QH.TaiKhoan == TextTaiKhoan.Text && QH.MatKhau == GetMD5(PassMatKhau.Password.ToString()))
                        {
                            MessageBox.Show("Đăng nhập thành công !");
                            dangNhap = false;
                            if (QH.chucvu == "Admin")
                            {
                                HamDangNhap(true, true);
                            }
                            else
                            {
                                HamDangNhap(true, false);
                            }
                        }
                    }
                }
                if (dangNhap == true)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập đũ thông tin ! ", "Thông báo !");
        }
        //Ham dang xuat khi thanh cong thi nguoi dung se khong su dung duoc cac chuc nang
        private void DangXuat_Click(object sender, RoutedEventArgs e)
        {
            HamDangNhap(false, false);
        }
        //Ham ma hoa code
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        private void miWebTV_Click(object sender, RoutedEventArgs e)
        {
            var WebThuVien = new LienKeWeb();
            WebThuVien.Show();
        }
        
    }
}
