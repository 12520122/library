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
    class TheLoaiSachViewModel : ViewModelBase
    {
        private ObservableCollection<LoaiSach> listLoaiSach;//Khai bao mot list Loai Sach
        public ObservableCollection<LoaiSach> ListLoaiSach
        {
            get
            {
                return listLoaiSach;
            }
            set
            {
                listLoaiSach = value;
                OnPropertyChanged("ListLoaiSach");
            }
        }
        private LoaiSach selectedLoaiSach;//Khai bao Chinh sua loai sach
        public LoaiSach SelectLoaiSach
        {
            get { return selectedLoaiSach; }
            set
            {
                if(selectedLoaiSach!=value)
                {
                    selectedLoaiSach = value;
                    OnPropertyChanged("SelectLoaiSach");
                    ChangeInput();
                }
            }
        }
        private String tenLoaiSach;//Khai bao ten loai sach
        public String TenLoaiSach
        {
            get { return tenLoaiSach; }
            set
            {
                if (tenLoaiSach != value)
                {
                    tenLoaiSach = value;
                    OnPropertyChanged("TenLoaiSach");
                }
            }
        }
        //Lua loai sach
        private ICommand saveCommand;
        private ICommand removeCommand;
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Xoa loai sach
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        }
        //Them mot loai sach
        private ICommand addNewCommand;
        public ICommand AddNewCommand
        {
            get { return addNewCommand; }
            set { addNewCommand = value; }
        }
        //Sua loai sach
        private ICommand editCommand;
        public ICommand EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; }
        }
        //Ham khoi tao lop TheLoaiSach
        public TheLoaiSachViewModel()
        {
            TenLoaiSach ="X";
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            RemoveCommand = new RelayCommand(new Action<object>(RemoveItems));
            AddNewCommand = new RelayCommand(new Action<object>(AddNewLoaiSach));
            EditCommand = new RelayCommand(new Action<object>(EditLoaiSach));
            using(var db=new QLTVContext())
            {
                ListLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
            }

        }
        //Show Thong bao them thanh cong hay that bai
        private void ShowMessage(object obj)
        {
            //Kiem tra xem ten loai sach da duowc nhap, neu duowc nhap thuc hien tiep, nguoc lai show thong bao
            if (TenLoaiSach != "")
            {
                //Hoi nguoi dung co muon luu, chon yes neu muon nguoc lai chon no
                MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu thông tin loại sách không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes, thuc hien tiep viec luu
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        MessageBox.Show("Thêm thành công : " + TenLoaiSach, "Thông báo!");
                        LoaiSach theloai = new LoaiSach();
                        theloai.TenLoaiSach = TenLoaiSach;
                        db.LoaiSachs.Add(theloai);
                        db.SaveChanges();
                        //ListLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
                        ListLoaiSach.Add(theloai);//Them loai sach vao list loai sach
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa nhập đũ thông tin!");
        }
        //Ham xoa mot item
        private void RemoveItems(object obj)
        {
            //Neu nguoi dung da chon item de xoa ti se thuc hien viec xoa
            if (SelectLoaiSach != null)
            {
                //Hoi  nguoi dung co muon xoa item, yes la dong y, no thi thoat ham
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa loại sách không ? ", "Thông báo ?",MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes thi thuc hien viec xoa
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        LoaiSach loaiSach = new LoaiSach();
                        loaiSach = db.LoaiSachs.FirstOrDefault(x => x.MaLoaiSach == SelectLoaiSach.MaLoaiSach);
                        if (loaiSach != null)
                        {
                            db.LoaiSachs.Remove(loaiSach);
                            db.SaveChanges();
                        }
                        ListLoaiSach.Remove(SelectLoaiSach);
                    }
                }
            }
            //Neu nguoi dung chua chon item de xoa se show thong bao
            else
                MessageBox.Show("Bạn chưa chọn thẻ để xóa ! ", "Thông báo !");
        }
        //Ham them mot item
        private void AddNewLoaiSach(object obj)
        {
            TenLoaiSach = "";
        }
        private void EditLoaiSach(object obj)
        {
            //neu nguoi dung chon item de sua
            if (SelectLoaiSach != null)
            {
                //Show thong bao muon sua hay khong, muon sua chon yes, nguoc lai chon no
                MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thông tin sách không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes thuc hien viec sua loai sach
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        LoaiSach loaisach = new LoaiSach();
                        loaisach = db.LoaiSachs.FirstOrDefault(x => x.MaLoaiSach == SelectLoaiSach.MaLoaiSach);
                        if (loaisach != null)
                        {
                            loaisach.TenLoaiSach = TenLoaiSach;
                            ListLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
                            db.SaveChanges();
                        }
                        //Show thong bao sua thanh cong
                        MessageBox.Show("Sửa thành công");
                    }
                }
            }
            //neu nguoi dung chua chon item de sua show ln thong bao
            else
                MessageBox.Show("Bạn chưa chọn thẻ loại sách để sữa!", "Thông báo !");
        }
        //Ham chuyen doi ten Loai Sach
        private void ChangeInput()
        {
            if (SelectLoaiSach != null)
            {
                TenLoaiSach = SelectLoaiSach.TenLoaiSach;
            }
            else
                TenLoaiSach = "";
        }
    }
}
