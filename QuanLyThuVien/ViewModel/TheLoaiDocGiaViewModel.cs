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
    class TheLoaiDocGiaViewModel : ViewModelBase
    {
        private ObservableCollection<LoaiDocGia> listLoaiDocGia; //Khai bao lisst de luu loai doc gia
        public ObservableCollection<LoaiDocGia> ListLoaiDocGia
        {
            get { return listLoaiDocGia; }
            set
            {
                listLoaiDocGia = value;
                OnPropertyChanged("ListLoaiDocGia");
            }
        }
        //Ham lua chon cac chinh sua cua loai doc gia
        private LoaiDocGia selectLoaiDocGia;
        public LoaiDocGia SelectLoaiDocGia
        {
            get { return selectLoaiDocGia; }
            set
            {
                if(selectLoaiDocGia!=value)
                {
                    selectLoaiDocGia = value;
                    OnPropertyChanged("SelectLoaiDocGia");
                    ChangeInput();
                }
            }
        }
        //Khai bao ten doc gia
        private string tenLoaiDocGia;
        public string TenLoaiDocGia
        {
            get { return tenLoaiDocGia; }
            set
            {
                tenLoaiDocGia = value;
                OnPropertyChanged("TenLoaiDocGia");
            }
        }

        private ICommand saveCommand;
        private ICommand removeCommand;
        //Ham luu loai doc gia
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Ham xoa loai doc gia
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        }
        //Ham them loai doc gia
        private ICommand addnewCommand;
        public ICommand AddNewCommand
        {
            get { return addnewCommand; }
            set { addnewCommand = value; }
        }
        //Ham chinh sua loai doc gia
        private ICommand editCommand;
        public ICommand EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; }
        }
        //Ham khoi tao class The Loai Doc Gia
        public TheLoaiDocGiaViewModel()
        {
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));//Goi ham show luu thanh cong hoac chua thanh cong
            RemoveCommand = new RelayCommand(new Action<object>(RemoveItems));//Goi ham xoa item khi muon xoa loai doc gia
            AddNewCommand = new RelayCommand(new Action<object>(AddNewItem));//Goi ham them item khi muon them mot loai doc gia
            EditCommand = new RelayCommand(new Action<object>(EditItem));//Goi ham chinh sua item khi muon chinh sua loai doc gia
            using(var db=new QLTVContext())
            {
                ListLoaiDocGia = new ObservableCollection<LoaiDocGia>(db.LoaiDocGias.ToList());
            }

        }
        //Ham show thanh cong hay that bai khi luu
        public void ShowMessage(object obj)
        {
            if (TenLoaiDocGia != "")//Khi da nhap ten loai doc gia thi se show thong bao co muon them hay khong
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu thông tin loại độc giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {

                        MessageBox.Show("Bạn đã thêm : " + TenLoaiDocGia, "Thông báo !");
                        LoaiDocGia loaidocgia = new LoaiDocGia();
                        loaidocgia.TenLoaiDocGia = TenLoaiDocGia;
                        db.LoaiDocGias.Add(loaidocgia);
                        db.SaveChanges();
                        // ListLoaiDocGia = new ObservableCollection<LoaiDocGia>(db.LoaiDocGias.ToList());
                        ListLoaiDocGia.Add(loaidocgia);
                        
                    }
                }
            }
            else //neu chua nhap ten loai doc gia ma an nut luu se show ra thong bao chua nhap ten loai doc gia cho nguoi dung
                MessageBox.Show("Bạn chưa nhập đũ thông tin!");
        }
        //Ham xoa mot item
        public void RemoveItems(object obj)
        {
            if (SelectLoaiDocGia != null)//Khi chon mot item
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa thông tin loại độc giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu chon yes thi se thuc hien xoa, no thi thoat ham
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        LoaiDocGia loaiDocGia = new LoaiDocGia();
                        loaiDocGia = db.LoaiDocGias.FirstOrDefault(x => x.MaLoaiDocGia == SelectLoaiDocGia.MaLoaiDocGia);
                        if (loaiDocGia != null)
                        {
                            db.LoaiDocGias.Remove(loaiDocGia);
                            db.SaveChanges();
                        }
                        ListLoaiDocGia.Remove(SelectLoaiDocGia);
                    }
                }
            }
            else //neu chua chon item ma da an nut xoa se show thong bao de nguoi dung chon
                MessageBox.Show("Bạn chưa chọn loại độc giả để xóa!");

        }
        //Ham them mot item moi
        private void AddNewItem(object obj)
        {
            TenLoaiDocGia = "";
        }
        //Ham chinh sua mot item
        private void EditItem(object obj)
        {
            if (SelectLoaiDocGia != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thông tin loại độc giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes se thuc hien sua, neu no thoat ham
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        LoaiDocGia loaidocgia = new LoaiDocGia();
                        loaidocgia = db.LoaiDocGias.FirstOrDefault(x => x.MaLoaiDocGia == SelectLoaiDocGia.MaLoaiDocGia);
                        if (loaidocgia != null)
                        {
                            loaidocgia.TenLoaiDocGia = TenLoaiDocGia;
                            ListLoaiDocGia = new ObservableCollection<LoaiDocGia>(db.LoaiDocGias.ToList());
                            db.SaveChanges();
                        }
                        MessageBox.Show("Sửa thành công!!!");
                    }
                }
            }
            else //Khi chua chon item ma nguoi dung da an nut chinh sua, se show thong bao cho nguoi dung biet
                MessageBox.Show("Bạn chưa chọn loại độc giả để sữa!");
        }
        //Ham thay doi dau va
        private void ChangeInput()
        {
            if (SelectLoaiDocGia != null) //neu lua chon khac null thi se gan ten doc gia voi ten doc gia hien co
            {
                TenLoaiDocGia = SelectLoaiDocGia.TenLoaiDocGia;
            }
            else //neu chon bang null se de trang
                TenLoaiDocGia = "";
        }
    }
}
