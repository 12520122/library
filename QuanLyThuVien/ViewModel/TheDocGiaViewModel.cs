using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    class TheDocGiaViewModel : ViewModelBase,IDataErrorInfo
    {
        private ObservableCollection<DocGia> listDocGia;
        public ObservableCollection<DocGia> ListDocGia
        {
            get { return listDocGia; }
            set
            {
                listDocGia = value;
                OnPropertyChanged("ListDocGia");
            }
        }
        private DocGia selectedDocGia;//Tao moi mot lop doc gia
        // ham selectDocGia trả về lớp ddowcj giả
        public DocGia SelectedDocGia
        {
            get { return selectedDocGia; }
            set
            {
                if (selectedDocGia != value)
                {
                    selectedDocGia = value;
                    OnPropertyChanged("SelectedDocGia");
                    UpdateInput();
                }
            }
        }

        private String hoTen;//Khai bao ten
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

        private LoaiDocGia selectedLoaiDocGia;//Khai bao loai doc gia
        public LoaiDocGia SelectedLoaiDocGia
        {
            get { return selectedLoaiDocGia; }
            set 
            { 
                selectedLoaiDocGia = value;
                OnPropertyChanged("SelectedLoaiDocGia");

            }
        }

        private String diaChi;//Khia bao dia chi
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

        private String email;//Khai bao email
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

        private DateTime ngaySinh = new DateTime(1994, 1, 1);//Khai bao ngay sinh măc dinh la ngay 01 thang 01 nam 1994
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                if (ngaySinh!=value)
                {
                    if (ngaySinh < DateTime.Today)
                    {
                        ngaySinh = value;
                        OnPropertyChanged("NgaySinh");
                    } 
                    else
                    {
                        //TODO: DatePicker textbox
                        //ngaySinh = new DateTime(1994, 1, 1);
                        //OnPropertyChanged("NgaySinh");
                        MessageBox.Show("Ngày sinh độc giả không lớn hơn ngay hiện tại!");
                    }
                }
            }
        }

        private DateTime ngayLapThe;//Khai bao ngay lap the
        public DateTime NgayLapThe
        {
            get { return ngayLapThe; }
            set
            {
                if (ngayLapThe !=value)
                {
                    ngayLapThe = value;
                    OnPropertyChanged("NgayLapThe");
                    UpdateNgayHetHan();
                }     
            }
        }
        private DateTime ngayHetHan;//Khai bao ngay het han
        public DateTime NgayHetHan
        {
            get
            {
                return ngayHetHan;
            }
            set
            {
                if (ngayHetHan!=value)
                {
                    ngayHetHan = value;
                    OnPropertyChanged("NgayHetHan");
                }
            }
        }
        private int tongNo;//Khai bao tong no
        public int TongNo
        {
            get { return tongNo; }
            set { tongNo = value; }
        }
        private ObservableCollection<LoaiDocGia> listLoaiDocGia;//Khai bao mot list doc gia
        public ObservableCollection<LoaiDocGia> ListLoaiDocGia
        {
            get
            {
                //var list = from tg in db1.TacGias select tg;
                //listTacGia = new ObservableCollection<TacGia>(list);
                return listLoaiDocGia;
            }
            set
            {
                if (listLoaiDocGia != value)
                {
                    listLoaiDocGia = value;
                    OnPropertyChanged("ListLoaiDocGia");
                }
            }
        }

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
                    case "HoTen":
                        if (string.IsNullOrEmpty(HoTen))
                        {
                            result = "Vui lòng nhập họ tên!!!";
                        }
                        //else
                        //{
                        //    bool isCorrect = Regex.IsMatch(HoTen, "^[a-zA-Z][a-zA-Z\\s]+$");
                        //    if(isCorrect==false)
                        //    {
                        //        result = "Họ tên không hợp lệ!!!";
                        //    }
                        //}
                        break;
                    case "DiaChi":
                        if (string.IsNullOrEmpty(DiaChi))
                        {
                            result = "Vui lòng nhập địa chỉ!!!";
                        }
                        break;
                    case "Email":
                        if (string.IsNullOrEmpty(Email))
                        {
                            result = "Vui lòng nhập email!!!";
                        }
                        else
                        {
                            bool isCorrect = Regex.IsMatch(Email, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                            if(isCorrect==false)
                            {
                                result = "Email không đúng!!!";
                            }
                        }
                        break;
                    case "TongNo":
                        if (TongNo < 0)
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

        private ICommand saveCommand;
        private ICommand removeCommand;
        //Ham luu
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Ham xoa
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        }
        //Ham sua
        private ICommand editCommand;
        public ICommand EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; }
        }
        //Ham them
        private ICommand addCommand;
        public ICommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; }
        }
        public TheDocGiaViewModel()
        {
            ClearInput();
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));//Neu la luu thi se goi ham show len thong bao luu thanh cong
            RemoveCommand = new RelayCommand(new Action<object>(RemoveItems));//Neu la ham xoa thì goi toi ham xoa item
            EditCommand = new RelayCommand(new Action<object>(EditItem));//Neu la ham edit thì goi toi ham edit item
            AddCommand = new RelayCommand(new Action<object>(AddItem));//Neu la ham add thì goi toi ham add item
            RefreshData();
            
        }
        //Ham load lai su lieu
        private void RefreshData()
        {
            SelectedDocGia = null;
            using (var db = new QLTVContext())
            {
                ListDocGia = new ObservableCollection<DocGia>(db.DocGias.ToList());
                ListLoaiDocGia = new ObservableCollection<LoaiDocGia>(db.LoaiDocGias.ToList());
                SelectedLoaiDocGia = db.LoaiDocGias.FirstOrDefault();
            }
        }
        //Ham show thong bao luu thanh cong
        public void ShowMessage(object obj)
        {
           // int giahan = 6;
            if (HoTen != "" || DiaChi != "")
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu thông tin độc giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        DocGia docGia = new DocGia();
                        docGia = new DocGia();

                        docGia.HoTen = HoTen;
                        docGia.MaLoaiDocGia = SelectedLoaiDocGia.MaLoaiDocGia;
                        docGia.NgaySinh = NgaySinh;
                        docGia.DiaChi = DiaChi;
                        docGia.Email = Email;
                        docGia.NgayLapThe = NgayLapThe;
                        //docGia.NgayHetHan = DateTime.Now.AddMonths(giahan);
                        docGia.NgayHetHan = NgayHetHan;
                        
                        docGia.TongNo = TongNo;
                        db.DocGias.Add(docGia);
                        db.SaveChanges();
                        //ListDocGia = new ObservableCollection<DocGia>(db.DocGias.Include("LoaiDocGia").ToList());
                        //ListLoaiDocGia = new ObservableCollection<LoaiDocGia>(db.LoaiDocGias.ToList());
                        // ListDocGia.Add(docGia);
                        MessageBox.Show("Độc giả " + HoTen + " đã được thêm\nMã độc giả: " + docGia.MaDocGia);
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập đũ thông tin!");
            
            RefreshData();
            ClearInput();
        }
        //Ham xoa mot item
        public void RemoveItems(object obj)
        {
            if (SelectedDocGia != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa độc giả không ? ", "Thông báo ?",MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        DocGia docGia = new DocGia();

                        docGia = db.DocGias.FirstOrDefault(x => x.MaDocGia == SelectedDocGia.MaDocGia);
                        db.DocGias.Remove(docGia);
                        db.SaveChanges();
                        ListDocGia.Remove(SelectedDocGia);
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn thẻ để xóa ! ", "Thông báo !");
            RefreshData();
            ClearInput();
            
        }
        //Ham sua mot item
        public void EditItem (object obj)
        {
            if(SelectedDocGia != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thông tin độc giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        DocGia docGia = new DocGia();
                        docGia = db.DocGias.First(x => x.MaDocGia == SelectedDocGia.MaDocGia);
                        docGia.HoTen = HoTen;
                        docGia.MaLoaiDocGia = SelectedLoaiDocGia.MaLoaiDocGia;
                        docGia.NgaySinh = NgaySinh;
                        docGia.DiaChi = DiaChi;
                        docGia.Email = Email;
                        docGia.NgayLapThe = NgayLapThe;
                        //docGia.NgayHetHan = DateTime.Now.AddMonths(giahan);
                        docGia.NgayHetHan = NgayHetHan;
                        docGia.TongNo = TongNo;
                        db.SaveChanges();
                    }
                }
            }
            else
               MessageBox.Show("Bạn chưa chọn độc giả để sữa!", "Thông báo !");
            RefreshData();
            ClearInput();
            
            //using (var db =new QLTVContext())
            //{

            //    //int giahan = 6;
            //        DocGia docGia = new DocGia();
            //        docGia = db.DocGias.FirstOrDefault(x => x.MaDocGia == SelectedDocGia.MaDocGia);
            //        if (docGia != null)
            //        {
            //            //ListDocGia.Remove(docGia);
                        
            //            docGia.HoTen = HoTen;
            //            docGia.MaLoaiDocGia = SelectedLoaiDocGia.MaLoaiDocGia;
            //            docGia.NgaySinh = NgaySinh;
            //            docGia.DiaChi = DiaChi;
            //            docGia.Email = Email;
            //            docGia.NgayLapThe = NgayLapThe;
            //            //docGia.NgayHetHan = DateTime.Now.AddMonths(giahan);
            //            docGia.NgayHetHan = NgayHetHan;
            //            docGia.TongNo = TongNo;
            //            ListDocGia = new ObservableCollection<DocGia>(db.DocGias.ToList());
                       
                        
            //        }
            //        db.SaveChanges();
            //        MessageBox.Show(HoTen);
                    
               
            //}

        }
        //Ham add mot item
       public void AddItem(object obj)
        {
            ClearInput();
        }
       //Ham lam trang cac text box de nhap

        private void ClearInput()
        {
            HoTen = "";
            DiaChi = "";
            Email = "";
            NgaySinh = new DateTime(1994, 1, 1);
            ngaySinh = new DateTime(1994, 1, 1);
            NgayLapThe = DateTime.Now;
        }
        private void UpdateNgayHetHan()
        {
            using (var db = new QLTVContext())
            {
                var thamSo = db.ThamSos.First(x => x.TenThamSo == "SoThangThoiHanThe");
                NgayHetHan = NgayLapThe.AddMonths(thamSo.GiaTri);
            }
        }

        private void UpdateInput()
        {
            //TODO: other windows
            if (SelectedDocGia != null)
            {
                HoTen = SelectedDocGia.HoTen;
                DiaChi = SelectedDocGia.DiaChi;
                Email = SelectedDocGia.Email;
                NgaySinh = SelectedDocGia.NgaySinh;
                NgayLapThe = SelectedDocGia.NgayLapThe;
                NgayHetHan = SelectedDocGia.NgayHetHan;
                SelectedLoaiDocGia = SelectedDocGia.LoaiDocGia;
            }
            else
                ClearInput();
        }
    }
}
