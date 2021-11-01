using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    public class DaoHanTheDocGia : ViewModelBase
    {
        private int maDocGia;

        //Ham MaDocGia: truyen gia tri cho bien maDocGia va lay gia tri cua bien do
        // Đối số truyền vào: Không có
        // Trả về kiểu int
        public int MaDocGia
        {
            get { return maDocGia; }
            set
            {
                maDocGia = value;
                OnPropertyChanged("MaDocGia");
            }
        }

        //Ten bien: hoten
        //Kieu du lieu: string
        private String hoTen;

        //Ham  HoTen: truyen gia tri cho bien hoten va lay gia tri tri cua bien hoten
        //Doi so truyen vao: khong co
        // Kieu tra ve: String
        public String HoTen
        {
            get { return hoTen; }
            set
            {
                if (hoTen != value)
                {
                    hoTen = value;
                    OnPropertyChanged("HoTen");
                }
            }
        }

        //Ten bien: loaiDocGia
        //Kieu du lieu: string
        private string loaiDocGia;
        // Ham LoaiDocGia: tra ve gia tri va lay gia tri cua bien loaiDocGia
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string LoaiDocGia
        {
            get { return loaiDocGia; }
            set
            {
                loaiDocGia = value;
                OnPropertyChanged("LoaiDocGia");
            }
        }

        // Ten bien: diaChi
        //Kieu du lieu: string
        private String diaChi;
        // Ham DiaChi: tra ve gia tri va lay gia tri cua bien diaChi
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public String DiaChi
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

        // Ten bien: email
        // kieu du lieu: string
        private String email;

        // Ham Email: tra ve gia tri va lay gia tri cua bien email
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public String Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        // Ten bien: ngaySinh
        // Kieu du lieu DateTime
        private DateTime ngaySinh;

        // Ham NgaySinh: tra ve gia tri va lay gia tri cua bien ngaySinh
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
                OnPropertyChanged("NgaySinh");
            }
        }

        // Ten bien: ngayHetHan
        // Kieu du lieu: DateTime
        private DateTime ngayHetHan;

        // Ham NgayHetHan: tra ve gia tri va lay gia tri cua bien ngayHetHan
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set
            {
                ngayHetHan = value;
                OnPropertyChanged("NgayHetHan");
            }
        }

        // Ten bien: searchDocGiaCommand
        // Kieu du lieu: ICommand
        private ICommand searchDocGiaCommand;

        // Ham SearchDocGiaCommand: tra ve gia tri va lay gia tri cua bien searchDocGiaCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand SearchDocGiaCommand
        {
            get { return searchDocGiaCommand; }
            set { searchDocGiaCommand = value; }
        }
        // Ten bien: daoHan
        // Kieu du lieu: ICommand
        private ICommand daoHan;

        // Ham DaoHan: tra ve gia tri va lay gia tri cua bien addDocGiaCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand DaoHan
        {
            get { return daoHan; }
            set { daoHan = value; }
        }

        //Ham chay luc khoi dong form

        public DaoHanTheDocGia()
        {
            MaDocGia = 0;
            SearchDocGiaCommand = new RelayCommand(new Action<object>(SearchDocGia));
            DaoHan = new RelayCommand(new Action<object>(HamDaoHan));
        }
        //khoi tao bien tam docgia
        DocGia docgia = new DocGia();
        // Ham  tao gia tim kiem doc gia  trong textbox MaDocGia
        // Dua ra man hinh thong cac doc gia do
        public void SearchDocGia(object obj)
        {
            docgia = new DocGia();
            using (var db = new QLTVContext())
            {
                foreach (DocGia DG in db.DocGias.ToList())
                {
                    if (DG.MaDocGia == MaDocGia)
                    {
                        docgia = DG;
                    }
                }
                if (docgia.HoTen == null)
                {
                    MessageBox.Show("Không tìm thấy độc giả !", "Thông báo!");
                }
                else
                {
                    HoTen = docgia.HoTen;
                    LoaiDocGia = docgia.LoaiDocGia.TenLoaiDocGia;
                    NgaySinh = docgia.NgaySinh;
                    DiaChi = docgia.DiaChi;
                    Email = docgia.Email;
                    NgayHetHan = docgia.NgayHetHan;
                    if (docgia.NgayHetHan < DateTime.Today)
                    {
                        MessageBox.Show("Thẻ độc giả này đã hết hạn !", "Thông báo !");
                    }
                    else
                    {
                        MessageBox.Show("Thẻ độc giả này còn hạn ! ", "Thông báo !");
                    }
                }
            }
        }

        // Ham su ly khi dao han them so ngay cua the doc gia
        // Luu sua ngay dao han trong the doc gia do
        public void HamDaoHan(object obj)
        {
            if (docgia.HoTen != null)
            {
                if (docgia.NgayHetHan < DateTime.Today)
                {
                    MessageBoxResult result = MessageBox.Show("Bạn có muốn gia hạn thẻ này thêm 6 tháng nữa không ? ", "Thông báo ! ", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        using (var db = new QLTVContext())
                        {
                            DocGia docGia = new DocGia();
                            docGia = db.DocGias.First(x => x.MaDocGia == docgia.MaDocGia);
                            docGia.HoTen = docgia.HoTen;
                            docGia.MaLoaiDocGia = docgia.MaLoaiDocGia;
                            docGia.NgaySinh = docgia.NgaySinh;
                            docGia.DiaChi = docgia.DiaChi;
                            docGia.Email = docgia.Email;
                            docGia.NgayLapThe = docgia.NgayLapThe;
                            //docGia.NgayHetHan = DateTime.Now.AddMonths(giahan);
                            docGia.NgayHetHan = docgia.NgayHetHan.AddMonths(6);
                            docGia.TongNo = docgia.TongNo;
                            db.SaveChanges();
                            MessageBox.Show("Đáo hạn thành công !", "Thông báo");
                            HoTen = "";
                            LoaiDocGia = "";
                            NgaySinh = new DateTime(1994,1,1);
                            DiaChi = "";
                            Email = "";
                            NgayHetHan = new DateTime(1994, 1, 1);
                            docgia = new DocGia();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Không thể đáo hạn. \nThẻ này chưa hết hạn !", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không phù hợp !", "Thông báo !");
            }
        }
    }
}
