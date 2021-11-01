using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyThuVien
{
    public class CThePhanQuyen : ViewModelBase
    {
        // khoi tao bien ten nguoi dung va han lien ket voi bien TenNguoiDung o ben form
        private string tenNguoiDung;
        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
            set
            {
                if (tenNguoiDung != value)
                {
                    tenNguoiDung = value;
                    OnPropertyChanged("TenNguoiDung");
                }
            }
        }
        // khoi tao bien di chi va han lien ket voi bien DiaChi o ben form
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                if (diaChi != value)
                {
                    diaChi = value;
                    OnPropertyChanged("DiaChi");
                }
            }
        }
        // khoi tao bien tai khoan va han lien ket voi bien TaiKhoan o ben form
        private string taiKhoan;
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set
            {
                if (taiKhoan != value)
                {
                    taiKhoan = value;
                    OnPropertyChanged("TaiKhoan");
                }
            }
        }
        // khoi tao bien mat khau va han lien ket voi bien MatKhau o ben form
        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set
            {
                if (matKhau != value)
                {
                    matKhau = value;
                    OnPropertyChanged("MatKhau");
                }
            }
        }
        // khoi tao bien nhap lai mat khau va han lien ket voi bien NhapLaiMapKhau o ben form
        private string nhapLaiMatKhau;
        public string NhapLaiMatKhau
        {
            get { return nhapLaiMatKhau; }
            set
            {
                if (nhapLaiMatKhau != value)
                {
                    nhapLaiMatKhau = value;
                    OnPropertyChanged("NhapLaiMatKhau");
                }
            }
        }
        // khoi tao bien chuc vu va han lien ket voi bien ChucVu o ben form
        private List<string> listChucVu;
        public List<string> ListChucVu
        {
            get { return listChucVu; }
            set
            {
                if(listChucVu != value)
                {
                    listChucVu = value;
                    OnPropertyChanged("ListChucVu");
                }
            }
        }
        // khoi tao bien selectChucVu va han lien ket voi bien SeclectedChucVu o ben form
        private string selectedChucVu;
        public string SelectedChucVu
        {
            get { return selectedChucVu; }
            set
            {
                if (selectedChucVu != value)
                {
                    selectedChucVu = value;
                    OnPropertyChanged("SelectedChucVu");
                }
            }
        }
        // khoi tao bien list thanh vien va han lien ket voi bien ListThanhVien o ben form
        private ObservableCollection<QuyenHan> listThanhVien;
        public ObservableCollection<QuyenHan> ListThanhVien
        {
            get { return listThanhVien; }
            set
            {
                if (listThanhVien != value)
                {
                    listThanhVien = value;
                    OnPropertyChanged("ListThanhVien");
                }
            }
        }
        // khoi tao bien selectedThanhVien va han lien ket voi bien SelectedThanhVien o ben form
        private QuyenHan selectedThanhVien;
        public QuyenHan SelectedThanhVien
        {
            get { return selectedThanhVien; }
            set
            {
                if (selectedThanhVien != value)
                {
                    selectedThanhVien = value;
                    OnPropertyChanged("SelectedThanhVien");
                    UpdateInput();
                }
            }
        }
        // Lien ket voi su kien cua bottom Them-click
        private ICommand them;
        public ICommand Them
        {
            get { return them; }
            set { them = value; }
        }
        // Lien ket voi su kien cua bottom Xoa-click
        private ICommand xoa;
        public ICommand Xoa
        {
            get { return xoa; }
            set { xoa = value; }
        }
        // Lien ket voi su kien cua bottom Sua-click
        private ICommand sua;
        public ICommand Sua
        {
            get { return sua; }
            set { sua = value; }
        }
        // Ham chay khi mo form
        public CThePhanQuyen()
        {
            Them = new RelayCommand(new Action<object>(HamThem));
            Xoa = new RelayCommand(new Action<object>(HamXoa));
            Sua = new RelayCommand(new Action<object>(HamSua));
            ListChucVu = new List<string> { "Admin", "Nhân Viên"};
            SelectedChucVu = ListChucVu.FirstOrDefault();
            using (var db = new QLTVContext())
            {
                ListThanhVien = new ObservableCollection<QuyenHan>(db.QuyenHans.ToList());
            }
        }
        // Ham them thanh vien vao dan sach thanh vien
        public void HamThem(object obj)
        {
            if(TenNguoiDung != "" || DiaChi != "")
            {
                if(MatKhau != "" || NhapLaiMatKhau != "")
                {
                    if(MatKhau == NhapLaiMatKhau)
                    {
                        using (var db = new QLTVContext())
                        {
                            foreach(QuyenHan gh in db.QuyenHans.ToList())
                            {
                                if(gh.TaiKhoan == TaiKhoan)
                                {
                                    MessageBox.Show("Tài khoản đã có người sữ dụng !","Thông báo !");
                                    return;
                                }
                            }
                            MessageBoxResult result = MessageBox.Show("Bạn có muốn thêm thành viên này không?", "Thông báo !", MessageBoxButton.YesNo);
                            if (result == MessageBoxResult.Yes)
                            {
                                QuyenHan QH = new QuyenHan();
                                QH.TenNguoiDung = TenNguoiDung;
                                QH.DiaChi = DiaChi;
                                QH.chucvu = SelectedChucVu;
                                QH.TaiKhoan = TaiKhoan;
                                QH.MatKhau = GetMD5(MatKhau);
                                db.QuyenHans.Add(QH);
                                db.SaveChanges();
                                MessageBox.Show("Đã thêm thanh viên thành công !", "Thông báo !");
                                ListThanhVien = new ObservableCollection<QuyenHan>(db.QuyenHans.ToList());
                                clearInput();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai mật khẩu !", "Thông báo !");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu !","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo !");
            }
        }
        // Ham xoa thanh vien trong danh sach thanh vien
        public void HamXoa (object obj)
        {
            if (SelectedThanhVien != null)
            {
               
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa thành viên này không ? ", "Thông báo ?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                   using (var db = new QLTVContext())
                   {
                        QuyenHan QH = new QuyenHan();
                        QH = db.QuyenHans.FirstOrDefault(x => x.MaNguoiDung == SelectedThanhVien.MaNguoiDung);
                        db.QuyenHans.Remove(QH);
                        db.SaveChanges();
                        ListThanhVien.Remove(SelectedThanhVien);
                        MessageBox.Show("Xóa Thành Công !", "Thôn báo !");
                        ListThanhVien = new ObservableCollection<QuyenHan>(db.QuyenHans.ToList());
                   }
                 }
            }                 
            else
            {
                MessageBox.Show("Bạn chưa chọn thẻ để xóa ! ", "Thông báo !");
            }
            
            clearInput();

        }
        // ham ma hoa mot chuoi string
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
        // Ham sua thanh vien trong danh sach
        public void HamSua(object obj)
        {
            if (SelectedThanhVien != null)
            {
                 if (TenNguoiDung != "" || DiaChi != "")
                {
                    if (MatKhau != "" || NhapLaiMatKhau != "")
                    {
                        if (MatKhau == NhapLaiMatKhau)
                        {
                            MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thành viên này không ? ", "Thông báo ?", MessageBoxButton.YesNo);
                            if (result == MessageBoxResult.Yes)
                            {
                                using (var db = new QLTVContext())
                                {
                                    QuyenHan QH = new QuyenHan();
                                    QH = db.QuyenHans.FirstOrDefault(x => x.MaNguoiDung == SelectedThanhVien.MaNguoiDung);
                                    QH.TaiKhoan = QH.TaiKhoan;
                                    QH.TenNguoiDung = TenNguoiDung;
                                    QH.MatKhau = GetMD5(MatKhau);
                                    QH.DiaChi = DiaChi;
                                    QH.chucvu = selectedChucVu;
                                    db.SaveChanges();
                                    MessageBox.Show("Sữa thành công !","Thông báo !");
                                    ListThanhVien = new ObservableCollection<QuyenHan>(db.QuyenHans.ToList());
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập sai mật khẩu !", "Thông báo !");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu !", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đủ thông tin !", "Thông báo !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thẻ đễ sữa !","Thông báo !");
            }
            clearInput();
        }
        // ham tao khoang trong trong textbox
        public void clearInput()
        {
            TenNguoiDung = "";
            DiaChi = "";
            TaiKhoan = "";
            MatKhau = "";
            NhapLaiMatKhau = "";
        }
        // Dua cac thong tin len textbox khi chon trong datagird
        private void UpdateInput()
        {
            //TODO: other windows
            if (SelectedThanhVien != null)
            {
                TenNguoiDung = SelectedThanhVien.TenNguoiDung;
                DiaChi = SelectedThanhVien.DiaChi;
                TaiKhoan = SelectedThanhVien.TaiKhoan;
                MatKhau = SelectedThanhVien.MatKhau;
                NhapLaiMatKhau = SelectedThanhVien.MatKhau;
                SelectedChucVu = SelectedThanhVien.chucvu;
            }
            else
                clearInput();
        }
    }
}
