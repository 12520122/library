using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace QuanLyThuVien
{
    class QuanLySachViewModel : ViewModelBase, IDataErrorInfo
    {
        #region IDataErrorInfo Members
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "TenDauSach":
                        if (string.IsNullOrEmpty(TenDauSach))
                        {
                            result = "Vui lòng nhập tên đầu sách!!!";
                        }
                        break;
                    case "NamXuatBan":
                        if (NamXuatBan <= 0)
                        {
                            result = "Năm không hợp lệ!!!";
                        }
                        break;
                    case "NhaXuatBan":
                        if (string.IsNullOrEmpty(NhaXuatBan))
                        {
                            result = "Vui lòng nhập nhà xuất bản!!!";
                        }
                        break;
                    case "SoLuong":
                        if (SoLuong <= 0)
                        {
                            result = "Vui lòng nhập lại!!!";
                        }
                        break;
                    case "TriGia":
                        if (TriGia <= 0)
                        {
                            result = "Vui lòng nhập lại!!!";
                        }
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
        #endregion

        // Tao list cac dau sach: listDauSach
        private ObservableCollection<DauSach> listDauSach;

        // Ham ListDauSach: tra ve gia tri va lay gia tri cua listDauSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: ObservableCollection<DauSach>
        public ObservableCollection<DauSach> ListDauSach
        {
            get { return listDauSach; }
            set
            {
                listDauSach = value;
                OnPropertyChanged("ListDauSach");
            }
        }

        // Ten bien: soLuong
        // Kieu du lieu: int
        private int soLuong;

        // Ham SoLuong: tra ve gia tri va lay gia tri cuar bien soLuong
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

        // Ten bien: tenDauSach
        // Kieu du lieu: string
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
                CheckIfDuplicateTenDauSach();
            }
        }
        //private DauSach DauSach { get; set; }
        // public string Tendausach { get { return DauSach.TenDauSach; } }
        //public int dongia { get { return DauSach.TriGia; } }

        // Ten bien: nhaXuatBan
        // Kieu du lieu: string
        private string nhaXuatBan;

        // Ham NhaXuatBan: tra ve gia tri va lay gia tri cua bien nhaXuatBan
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set
            {
                nhaXuatBan = value;
                OnPropertyChanged("NhaXuatBan");
            }
        }

        // Ten bien: namXuatBan
        // Kieu du lieu: int
        private int namXuatBan;

        // Ham NamXuatBan: tra ve gia tri va lay gia tri cua bien namXuatBan
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int NamXuatBan
        {
            get { return namXuatBan; }
            set
            {
                namXuatBan = value;
                OnPropertyChanged("NamXuatBan");
            }
        }

        // Ten bien: triGia
        // Kieu du lieu: int
        private int triGia;

        // Ham TriGia: tra ve gia tri va lay gia tri cua bien triGia
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int TriGia
        {
            get { return triGia; }
            set
            {
                triGia = value;
                OnPropertyChanged("TriGia");
            }
        }

        //Ten bien: ngayNhap
        // Kieu du lieu: DateTime
        private DateTime ngayNhap = DateTime.Now.Date;

        // Ham NgayNhap: tra ve gia tri va lay gia tri cua bien ngayNhap
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        // Tao mot listLoaiSach
        private ObservableCollection<LoaiSach> listLoaiSach;

        // Ham ListLoaiSach: tra ve gia tri va lay gia tri cua listLoaiSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: bservableCollection<LoaiSach> 
        public ObservableCollection<LoaiSach> ListLoaiSach
        {
            get
            {
                //var list = from tg in db1.TacGias select tg;
                //listTacGia = new ObservableCollection<TacGia>(list);
                return listLoaiSach;
            }
            set
            {
                if (listLoaiSach != value)
                {
                    listLoaiSach = value;
                    OnPropertyChanged("ListLoaiSach");
                }
            }
        }

        // Ten Bien: selectedLoaiSach
        // Kieu du lieu: LoaiSach
        private LoaiSach selectedLoaiSach;

        // Ham SelectedLoaiSach: tra ve gia tri va lay gia tri cua selectedLoaiSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: LoaiSach

        public LoaiSach SelectedLoaiSach
        {
            get { return selectedLoaiSach; }
            set
            {
                if (selectedLoaiSach != value)
                {
                    selectedLoaiSach = value;
                    OnPropertyChanged("SelectedLoaiSach");
                }
            }
        }

        // Ten bien: selectedDauSach
        // Kieu du lieu: DauSach
        private DauSach selectedDauSach;

        // Ham SelectedDauSach : tra ve gia tri va lay gia tri cua selectedDauSach
        // Doi so truyen vao: khong co
        // Kieu tra ve: DauSach

        public DauSach SelectedDauSach
        {
            get { return selectedDauSach; }
            set
            {
                if (selectedDauSach != value)
                {
                    selectedDauSach = value;
                    OnPropertyChanged("SelectedDauSach");
                    ChangeInput();
                }
            }
        }

        // Ham ListTacGiaView 
        // Doi so truyen vao: khong co
        // Kieu tra ve: IEnumerable<TacGia>
        public IEnumerable<TacGia> ListTacGiaView
        {
            get;
            set;

        }
        //public ObservableCollection<TacGia> ListTacGia { get; set; }
        //public ICollectionView ListTacGiaView
        //{
        //    get
        //    {
        //        if (listTacGiaView == null)
        //            listTacGiaView = CollectionViewSource.GetDefaultView(ListTacGia);
        //        return listTacGiaView;
        //    }
        //}
        //private ICollectionView listTacGiaView;

        //public IEnumerable<TacGia> SelectedTacGias
        //{
        //    get; //{ return ListTacGia.Where(o => o.IsSelected); }
        //    set;
        //}

        // Tao mot list TacGia
        private ObservableCollection<TacGia> selectedTacGias = new ObservableCollection<TacGia>();

        // Ham SelectedTacGias :lay gia tri selectedTacGias
        // Doi so truyen vao: khong co
        // Kieu tra ve: ObservableCollection<TacGia> 
        public ObservableCollection<TacGia> SelectedTacGias
        {
            get { return selectedTacGias; }
            //set
            //{
            //    if (selectedTacGias != value)
            //    {
            //        selectedTacGias = value;
            //        OnPropertyChanged("SelectedTacGias");
            //    }
            //}
        }


        // Ten bien: saveCommand
        // Kieu du lieu: ICommand
        private ICommand saveCommand;

        // Ham SaveCommand : tra ve gia tri va lay gia tri cua saveCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }

        // Ten bien: addNewCommand
        // Kieu du lieu: ICommand
        private ICommand addNewCommand;

        // Ham AddNewCommand: tra ve gia tri va lay gia tri cua addNewCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommad
        public ICommand AddNewCommand
        {
            get { return addNewCommand; }
            set { addNewCommand = value; }
        }

        // Ten bien: editCommand
        // Kieu du lieu: ICommand
        private ICommand editCommand;

        // Ham EditCommand: tra ve gia tri va lay gia tri cua editCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; }
        }

        // Ten bien: removeCommand
        // Kieu du lieu: ICommand
        private ICommand removeCommand;

        // Ham RemoveCommand: tra ve gia tri va lay gia tri cua removeCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve:  ICommand
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        }

        // Ham QuanLySachViewModel(): ham khoi tao mac dinh cua class
        // Doi so truyen vao: khong co
        // Kieu tra ve: khong co
        public QuanLySachViewModel()
        {
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            AddNewCommand = new RelayCommand(new Action<object>(AddNew));
            EditCommand = new RelayCommand(new Action<object>(EditItems));
            RemoveCommand = new RelayCommand(new Action<object>(RemoveItems));

            using (var db = new QLTVContext())
            {
                ListDauSach = new ObservableCollection<DauSach>(db.DauSachs.Include("CuonSachs").Include("TacGias").ToList());
                ListLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
                SelectedLoaiSach = db.LoaiSachs.FirstOrDefault();
                //ListTacGia = new ObservableCollection<TacGia>(db.TacGias.ToList());
                ListTacGiaView = db.TacGias.ToList();

                //SelectedTacGias.Add(ListTacGiaView.First());
            }
        }


        // Ham ShowMessage: show cac thong bao 
        // Doi so truyen vao: obj(object) 
        // Kieu tra ve: void
        private void ShowMessage(object obj)
        {
            if (SoLuong <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0");
                return;
            }

            using (var db = new QLTVContext())
            {
                int SoNamThoiHanXuatBan = db.ThamSos.First(x => x.TenThamSo == "SoNamThoiHanXuatBan").GiaTri;
                if (DateTime.Today.Year - NamXuatBan > SoNamThoiHanXuatBan)
                {
                    MessageBox.Show("Chỉ nhận các sách xuất bản trong vòng " + SoNamThoiHanXuatBan + " năm");
                    return;
                }
                if (TenDauSach != "" || NhaXuatBan != "")
                {
                    MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu thông tin sách không ?", "Thông báo !", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        //MessageBox.Show(TenDauSach);
                        DauSach dauSach;
                        //TODO: TACGIA
                        dauSach = db.DauSachs.FirstOrDefault(x => x.TenDauSach == TenDauSach && x.NamXB == NamXuatBan
                            && x.NhaXB == NhaXuatBan && x.LoaiSach.TenLoaiSach == SelectedLoaiSach.TenLoaiSach && x.TriGia == TriGia);
                        if (dauSach == null)
                        {
                            dauSach = new DauSach();
                            dauSach.TenDauSach = TenDauSach;
                            dauSach.NhaXB = NhaXuatBan;
                            dauSach.NamXB = NamXuatBan;
                            dauSach.TriGia = TriGia;
                            dauSach.MaLoaiSach = SelectedLoaiSach.MaLoaiSach;
                            foreach (var tacGia in SelectedTacGias)
                            {
                                var tg = db.TacGias.First(x => x.MaTacGia == tacGia.MaTacGia);
                                dauSach.TacGias.Add(tg);
                            }
                            db.DauSachs.Add(dauSach);
                        }
                        //db.SaveChanges();
                        AddCuonSachToDauSach(db, dauSach);

                        //db.DauSachs.Add(dauSach);
                        //db.SaveChanges();
                        ListDauSach = new ObservableCollection<DauSach>(db.DauSachs.Include("LoaiSach").Include("CuonSachs").Include("TacGias").ToList());
                    }
                }
                else
                    MessageBox.Show("Bạn chưa nhập đũ thông tin!");
            }
        }


        // Ham AddCuonSachToDauSach: them mot cuon sach moi vao
        // Doi so truyen vao: db, dausach
        // Kieu tra ve: void
        private void AddCuonSachToDauSach(QLTVContext db, DauSach dauSach)
        {
            List<CuonSach> list = new List<CuonSach>();
            for (int i = 0; i < SoLuong; i++)
            {
                CuonSach cuonSach = new CuonSach();
                cuonSach.TinhTrangSach = false;
                cuonSach.DauSach = dauSach;
                db.CuonSachs.Add(cuonSach);
                list.Add(cuonSach);
                //dauSach.CuonSachs.Add(cuonSach);
            }
            db.SaveChanges();
            StringBuilder str = new StringBuilder();
            foreach (var item in list)
            {
                str.Append("\n").Append(item.MaCuonSach);
            }
            MessageBox.Show(SoLuong + " cuốn sách vừa nhập có mã sách là:" + str);
        }


        // Ham CheckIfDuplicateTenDauSach(): kiem tra xem da co sach giong ten sach do chua
        // Doi so truyen vao: khong co
        // Kieu tra ve: void
        private void CheckIfDuplicateTenDauSach()
        {
            using (var db = new QLTVContext())
            {
                var dauSach = db.DauSachs.FirstOrDefault(x => x.TenDauSach == TenDauSach);
                if (dauSach == null)
                    return;
                var result = MessageBox.Show("Đã có đầu sách giống tên với đầu sách này.\nBạn muốn thêm số lượng sách vào đầu sách đã có?", "", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    foreach (var item in ListLoaiSach)
                    {
                        if (item.MaLoaiSach == dauSach.MaLoaiSach)
                            SelectedLoaiSach = item;
                    }
                    NamXuatBan = dauSach.NamXB;
                    NhaXuatBan = dauSach.NhaXB;
                    TriGia = dauSach.TriGia;
                }
            }

        }


        // Ham AddNew: dua form ve ban dau de nhap moi
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void 
        private void AddNew(object obj)
        {
            ClearAllInput();
        }

        // Ham ClearAllInput(): xoa de nhap moi
        // Doi so truyen vao: khong co
        // Kieu tra ve: void
        private void ClearAllInput()
        {
            TenDauSach = "";
            NamXuatBan = 0;
            NhaXuatBan = "";
            SoLuong = 0;
            TriGia = 0;
        }

        // Ham EditItems: Sua thong tin cua cuon sach
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        private void EditItems(object obj)
        {
            if (SelectedDauSach != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thông tin sách không ?", "Thông báo !", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        DauSach dauSach = new DauSach();
                        dauSach = db.DauSachs.FirstOrDefault(x => x.TenDauSach == SelectedDauSach.TenDauSach
                            && x.NamXB == SelectedDauSach.NamXB && x.NhaXB == SelectedDauSach.NhaXB && x.TriGia == SelectedDauSach.TriGia);
                        //CuonSach cuonsach = new CuonSach();
                        //cuonsach = db.CuonSachs.FirstOrDefault(x => x.DauSach.TenDauSach == SelectedDauSach.TenDauSach);
                        if (dauSach != null)
                        {
                            dauSach.TenDauSach = TenDauSach;
                            dauSach.NhaXB = NhaXuatBan;
                            dauSach.NamXB = NamXuatBan;

                            dauSach.TriGia = TriGia;
                            dauSach.MaLoaiSach = SelectedLoaiSach.MaLoaiSach;
                            foreach (var tacGia in SelectedTacGias)
                            {
                                var tg = db.TacGias.First(x => x.MaTacGia == tacGia.MaTacGia);
                                dauSach.TacGias.Add(tg);
                            }
                            db.SaveChanges();
                        }
                        ListDauSach = new ObservableCollection<DauSach>(db.DauSachs.Include("LoaiSach").Include("CuonSachs").Include("TacGias").ToList());
                        MessageBox.Show("Sửa thành công");
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn thẻ để sữa ! ", "Thông báo !");

        }

        // Ham RemoveItems: Xoa mot cuon sach
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        private void RemoveItems(object obj)
        {
            if (selectedDauSach != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa sách không ? ", "Thông báo ?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        DauSach dausach = new DauSach();
                        dausach = db.DauSachs.FirstOrDefault(x => x.TenDauSach == SelectedDauSach.TenDauSach
                            && x.NamXB == SelectedDauSach.NamXB && x.NhaXB == SelectedDauSach.NhaXB && x.TriGia == SelectedDauSach.TriGia);
                        CuonSach cuonsach = new CuonSach();
                        cuonsach = db.CuonSachs.FirstOrDefault(x => x.DauSach.TenDauSach == SelectedDauSach.TenDauSach);
                        if (dausach != null)
                        {
                            db.DauSachs.Remove(dausach);
                            db.CuonSachs.Remove(cuonsach);
                            db.SaveChanges();
                        }
                        ListDauSach.Remove(SelectedDauSach);
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn thẻ để xóa ! ", "Thông báo !");
        }

        // Ham ChangeInput: Luu thong tin vua nhap hoac thong tin vua sua
        // Doi so truyen vao: khong co
        // Kieu tra ve: void
        private void ChangeInput()
        {
            if (SelectedDauSach != null)
            {
                TenDauSach = SelectedDauSach.TenDauSach;
                SelectedLoaiSach = SelectedDauSach.LoaiSach;
                NamXuatBan = SelectedDauSach.NamXB;
                NhaXuatBan = SelectedDauSach.NhaXB;
                SoLuong = SelectedDauSach.CuonSachs.Count;
                TriGia = SelectedDauSach.TriGia;
                SelectedTacGias.Clear();
                foreach (var tacGia in selectedDauSach.TacGias)
                {
                    selectedTacGias.Add(tacGia);
                }
                //SelectedTacGias = selectedDauSach.TacGias;
            }
            else
            {
                TenDauSach = "";
                NamXuatBan = 0;
                NhaXuatBan = "";
                SoLuong = 0;
                TriGia = 0;
            }
        }
    }
}
