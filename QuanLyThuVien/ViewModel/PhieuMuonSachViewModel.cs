using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace QuanLyThuVien
{
    public class PhieuMuonSachViewModel : ViewModelBase
    {
        //private ObservableCollection<PhieuMuon> listMuon;
        //public ObservableCollection<PhieuMuon> ListMuon
        //{
        //    get { return listMuon; }
        //    set 
        //    {
        //        listMuon = value;
        //        OnPropertyChanged("ListMuon");
        //    }
        //}

        // Tao list nhung cuon sach
        private ObservableCollection<CuonSach> listCuonSach;

        //Ham  ListCuonSach: truyen gia tri cho listCuonSach va lay gia tri tri cua listCuonSach
        // Đối số truyền vào: Không có
        // Trả về kiểu List 
        public ObservableCollection<CuonSach> ListCuonSach
        {
            get { return listCuonSach; }
            set
            {
                listCuonSach = value;
                OnPropertyChanged("ListCuonSach");
            }
        }

        //private PhieuMuon selectedPhieuMuon;
        //public PhieuMuon SelectedPhieuMuon
        //{
        //    get { return selectedPhieuMuon; }
        //    set
        //    {
        //        selectedPhieuMuon = value;
        //        OnPropertyChanged("SelectedPhieuMuon");
        //    }
        //}

        //Khai bao bien maDocGia
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

        // Ten bien: maCuonSach
        // Kieu du lieu: int
        private int maCuonSach;

        // Ham MaCuonSach: tra ve gia tri va lay gia tri cua bien maCuonSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int MaCuonSach
        {
            get { return maCuonSach; }
            set
            {
                maCuonSach = value;
                OnPropertyChanged("MaCuonSach");
            }

        }

        // Ten bien: tinhTrangSach
        // Kieu du lieu: bool
        private bool tinhTrangSach;

        // Ham TinhTrangSach: tra ve gia tri va lay gia tri cua bien tinhTrangSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public bool TinhTrangSach
        {
            get { return tinhTrangSach; }
            set { tinhTrangSach = value; }
        }


        // Ten bien: TheLoaiSach
        // Kieu tra ve: string
        private string theLoaiSach;

        // Ham TheLoaiSach: tra ve gia tri va lay gia tri cua bien theLoaiSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string TheLoaiSach
        {
            get { return theLoaiSach; }
            set
            {
                theLoaiSach = value;
                OnPropertyChanged("TheLoaiSach");
            }
        }

        // Ten bien: tenTacGia
        // Kieu du lieu: string
        private string tenTacGia;

        // Ham TenTacGia: tra ve gia tri va lay gia tri cua bien tenTacGia
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string TenTacGia
        {
            get { return tenTacGia; }
            set
            {
                tenTacGia = value;
                OnPropertyChanged("TenTacGia");
            }
        }

        // Ten bien: tenDauSach
        // Kieu du lieu: String
        private string tenDauSach;

        // Ham TenDauSach: tra ve gia tri va lay gia tri cua bien tenDauSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string TenDauSach
        {
            get { return tenDauSach; }
            set
            {
                tenDauSach = value;
                OnPropertyChanged("TenDauSach");
            }
        }

        // Ten bien: ngayMuon
        // Kieu du lieu: DateTime
        private DateTime ngayMuon = DateTime.Now;

        // Ham NgayMuon: tra ve gia tri va lay gia tri cua bien ngayMuon
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set
            {
                ngayMuon = value;
                OnPropertyChanged("NgayMuon");
            }

        }

        // Ten bien: isEnable
        // Kieu du lieu: bool
        private bool isEnable;

        // Ham IsEnable: tra ve gia tri va lay gia tri cua bien isEnable
        // Doi so truyen vao: khong co
        // Kieu tra ve: bool
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                if (isEnable != value)
                {
                    isEnable = value;
                    OnPropertyChanged("IsEnable");
                }
            }
        }
        //private bool isEnableS;
        //public bool IsEnableS
        //{
        //    get { return isEnableS; }
        //    set
        //    {
        //        if (isEnableS != value)
        //        {
        //            isEnableS = value;
        //            OnPropertyChanged("IsEnableS");
        //        }
        //    }
        //}

        // Ten bien: soLuong
        // Kieu du lieu: int
        private int soLuong;

        // Ham SoLuong: tra ve gia tri va lay gia tri cua bien soLuong
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                soLuong = value;
                OnPropertyChanged("SoLuong");
            }
        }

        // Ten bien: saveCommand
        // Kieu du lieu: ICommand
        private ICommand saveCommand;

        // Ham SaveCommand: tra ve gia tri va lay gia tri cua bien saveCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
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

        // Ten bien: searchSachCommand
        // Kieu du lieu: ICommand
        private ICommand searchSachCommand;

        // Ham SearchSachCommand: tra ve gia tri va lay gia tri cua bien searchSachCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand SearchSachCommand
        {
            get { return searchSachCommand; }
            set { searchSachCommand = value; }
        }

        // Ten bien: addNewCommand
        // Kieu du lieu: ICommand
        private ICommand addNewCommand;

        // Ham AddNewCommand: tra ve gia tri va lay gia tri cua bien addNewCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand AddNewCommand
        {
            get { return addNewCommand; }
            set { addNewCommand = value; }
        }

        // Ten bien: addCuonSachCommand
        // Kieu du lieu: ICommand
        private ICommand addCuonSachCommand;

        // Ham AddCuonSachCommand: tra ve gia tri va lay gia tri cua bien addCuonSachCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand AddCuonSachCommand
        {
            get { return addCuonSachCommand; }
            set { addCuonSachCommand = value; }
        }

        // Ham PhieuMuonSachViewModel(): Khoi tao gia tri 
        // Doi so truyen vao: khong co
        // Kieu tra ve: Khong co
        public PhieuMuonSachViewModel()
        {
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            SearchDocGiaCommand = new RelayCommand(new Action<object>(SearchDocGia));
            SearchSachCommand = new RelayCommand(new Action<object>(SearchSach));
            AddNewCommand = new RelayCommand(new Action<object>(Add));
            AddCuonSachCommand = new RelayCommand(new Action<object>(AddCuonSach));

            ListCuonSach = new ObservableCollection<CuonSach>();
            //using (var db = new QLTVContext())
            //{
            //    ListMuon = new ObservableCollection<PhieuMuon>(db.PhieuMuons.Include("CuonSach").ToList());
            //    ListMuon.Clear();

            //}
            IsEnable = true;

        }

        //private void ShowMessage(object obj)
        //{
        //    //PhieuMuon pm = new PhieuMuon();

        //    //// PhieuMuon pm = new PhieuMuon();
        //    using (var db = new QLTVContext())
        //    {
        //        NgayMuon = DateTime.Now;
        //        var docGia = db.DocGias.FirstOrDefault(x => x.MaDocGia == MaDocGia);
        //        var cuonSach = db.CuonSachs.FirstOrDefault(x => x.MaCuonSach == MaCuonSach);
        //        SoLuong = db.PhieuMuons.Count(x => x.DocGia.MaDocGia == MaDocGia);
        //        if (docGia != null && cuonSach != null)
        //        {
        //            DiaChi = docGia.DiaChi;
        //            Email = docGia.Email;
        //            HoTen = docGia.HoTen;
        //            NgayHetHan = docGia.NgayHetHan;
        //            NgaySinh = docGia.NgaySinh;

        //            TenDauSach = cuonSach.DauSach.TenDauSach;
        //            MaCuonSach = cuonSach.MaCuonSach;
        //            TenDauSach = cuonSach.DauSach.TenDauSach;
        //            //TheLoaiSach = cuonSach.DauSach.LoaiSach.TenLoaiSach;

        //            PhieuMuon pm = new PhieuMuon();
        //          //  pm = db.PhieuMuons.FirstOrDefault(x => x.MaDocGia == MaDocGia && x.NgayMuon ==NgayMuon);
        //          //  if (pm == null)
        //          //  {
        //                pm.MaDocGia = MaDocGia;
        //                pm.NgayMuon = NgayMuon;
        //                pm.MaCuonSach = MaCuonSach;
        //               // pm.CuonSach.DauSach.TenDauSach = cuonSach.DauSach.TenDauSach;
        //                db.PhieuMuons.Add(pm);
        //                listMuon.Add(pm);

        //                db.SaveChanges();
        //           // ListMuon = new ObservableCollection<PhieuMuon>(db.PhieuMuons.Include("CuonSach").ToList());
        //          //ListMuon = new ObservableCollection<PhieuMuon>(db.PhieuMuons.Include("Phieu").Where(x => x.MaDocGia == MaCuonSach).ToList());
        //        }
        //        IsEnable = false;


        //    }
        //}

        // Khai bao cac bien phu
        int soSachMuon = 0;
        int soSachMuonLanTruoc = 0;
        DocGia docGiaViewModel;

        // Ham SearchDocGia: Tim kiem mot doc gia khi biet ma doc gia
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        public void SearchDocGia(object obj)
        {
            using (var db = new QLTVContext())
            {
                //DocGia docGiaViewModel;// = new DocGia();
                docGiaViewModel = db.DocGias.FirstOrDefault(x => x.MaDocGia == MaDocGia);
                if (docGiaViewModel != null)
                {
                    if (docGiaViewModel.NgayHetHan < NgayMuon)
                    {
                        MessageBox.Show("Thẻ độc giả này đã hết hạn");
                        return;
                    }

                    var listDangMuon = db.PhieuMuons.Where(x => x.MaDocGia == MaDocGia && x.DaTra == false).ToList();
                    soSachMuonLanTruoc = listDangMuon.Count;
                    soSachMuon = soSachMuonLanTruoc;
                    int SoNgayMuonToiDa = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa").GiaTri;
                    bool isMuonQuaHan = false;
                    foreach (var item in listDangMuon)
                    {
                        if (item.NgayMuon < DateTime.Today.AddDays(-SoNgayMuonToiDa))
                        {
                            isMuonQuaHan = true;
                            break;
                        }
                    }
                    if (isMuonQuaHan)
                    {
                        MessageBox.Show("Đọc giả còn sách mượn quá hạn, không được mượn tiếp");
                        docGiaViewModel = null;
                        return;
                    }
                    if (soSachMuon == 5)
                    {
                        MessageBox.Show("Đọc giả đã mượn số sách tối đa chưa trả, không được mượn tiếp");
                        docGiaViewModel = null;
                        return;
                    }
                    HoTen = docGiaViewModel.HoTen;
                    NgaySinh = docGiaViewModel.NgaySinh;
                    NgayHetHan = docGiaViewModel.NgayHetHan;
                    DiaChi = docGiaViewModel.DiaChi;
                    Email = docGiaViewModel.Email;
                    LoaiDocGia = docGiaViewModel.LoaiDocGia.TenLoaiDocGia;
                    //IsEnable = false;
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Không tìm thấy độc giả!!!");// Bạn muốn thêm độc giả không?", "Thông Báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    //if(result == MessageBoxResult.Yes)
                    //{

                    //}
                    //else
                    //{
                    //    HoTen = "";
                    //    DiaChi = "";
                    //    Email = "";
                    //    LoaiDocGia = "";
                    //    NgaySinh = new DateTime();
                    //    NgayHetHan = new DateTime();


                    //}
                }

            }
        }

        // Ten bien: cuonSachViewModel
        // Kieu du lieu: CuonSach
        CuonSach cuonSachViewModel = new CuonSach();

        // Ham SearchSach: Tim kiem mot sach khi biet ma sach
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        public void SearchSach(object obj)
        {
            using (var db = new QLTVContext())
            {
                //CuonSach cuonSachViewModel = new CuonSach();
                cuonSachViewModel = db.CuonSachs.FirstOrDefault(x => x.MaCuonSach == MaCuonSach);
                if (cuonSachViewModel != null)
                {
                    if (cuonSachViewModel.TinhTrangSach == true)
                    {
                        MessageBox.Show("Sách này đã được cho mượn");
                        cuonSachViewModel = null;
                        return;
                    }
                    TenDauSach = cuonSachViewModel.DauSach.TenDauSach;

                    // TheLoaiSach = cuonsach.DauSach.LoaiSach.TenLoaiSach;
                    //TenTacGia = cuonsach.DauSach.TacGia.TenTacGia;

                }
                else
                {
                    MessageBox.Show("Không tìm thấy!!!");
                    TenDauSach = "";
                }
            }
        }


        // Ham Add: Xoa cac input form de nhap phieu muon sach moi
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        public void Add(object obj)
        {
            ClearAllInput();
            IsEnable = true;
            ListCuonSach.Clear();
            soSachMuon = 0;
            //IsEnableS = true;

        }
        private void ClearAllInput()
        {
            MaDocGia = 0;
            MaCuonSach = 0;
            HoTen = "";
            Email = "";
            NgayHetHan = DateTime.Now;
            NgaySinh = DateTime.Now;
            LoaiDocGia = "";
            TenDauSach = "";
            DiaChi = "";
            //using (var db = new QLTVContext())
            //{
            //    ListMuon = new ObservableCollection<PhieuMuon>(db.PhieuMuons.ToList());
            //    ListMuon.Clear();

            //}
        }

        // Ham AddCuonSach: luu phieu muon
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        private void AddCuonSach(object obj)
        {
            if (cuonSachViewModel == null)
                return;
            ++soSachMuon;
            if (soSachMuon > 5)
            {
                string str = "";
                if (soSachMuonLanTruoc > 0)
                    str = "Đọc giả còn " + soSachMuonLanTruoc + " quyển chưa trả\n";
                MessageBox.Show(str + "Đọc giả chỉ được mượn tối đa 5 quyển");
                return;
            }
            ListCuonSach.Add(cuonSachViewModel);
        }

        // Ham  ShowMessage: show ra cac loi khi nhap phieu muon
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        private void ShowMessage(object obj)
        {
            if (docGiaViewModel == null)
            {
                MessageBox.Show("Chưa nhập thông tin độc giả");
                return;
            }
            if (ListCuonSach.Count == 0)
            {
                MessageBox.Show("Chưa nhập các sách cần trả");
                return;
            }
            using (var db = new QLTVContext())
            {
                foreach (var cuonSach in ListCuonSach)
                {
                    PhieuMuon phieuMuon = new PhieuMuon();
                    int iNgayhethan = 0;
                    foreach(ThamSo TS in db.ThamSos)
                    {
                        if(TS.TenThamSo == "SoNgayMuonToiDa")
                        {
                            iNgayhethan = TS.GiaTri;
                        }
                    }
                    phieuMuon.NgayMuon = NgayMuon;
                    phieuMuon.NgayHetHan = NgayMuon.AddDays(iNgayhethan);
                    phieuMuon.MaDocGia = docGiaViewModel.MaDocGia;
                    var cs = db.CuonSachs.First(x => x.MaCuonSach == cuonSach.MaCuonSach);
                    //db.Set<CuonSach>().Attach(cuonSach);
                    cs.TinhTrangSach = true;
                    phieuMuon.MaCuonSach = cs.MaCuonSach;
                   
                    db.PhieuMuons.Add(phieuMuon);
                }
                db.SaveChanges();

            }
            MessageBox.Show("Cho mượn thành công");
            var e = Application.Current.Windows.GetEnumerator();
            while (e.MoveNext())
            {
                Window value = e.Current as Window;
                if (value.Title == "PHIẾU MƯỢN SÁCH")
                    value.Close();
            }
        }

    }
}
