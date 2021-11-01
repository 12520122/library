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
    class TheTacGiaViewModel : ViewModelBase
    {
        //Khai bao danh sach tac gia
        private ObservableCollection<TacGia> listTacGia;
        public ObservableCollection<TacGia> ListTacGia
        {
            get
            {
                //var list = from tg in db1.TacGias select tg;
                //listTacGia = new ObservableCollection<TacGia>(list);
                return listTacGia;
            }
            set
            {
                if (listTacGia != value)
                {
                    listTacGia = value;
                    OnPropertyChanged("ListTacGia");
                }
            }
        }
        //Khai bao ten tac gia
        private String tenTacGia;
        public String TenTacGia
        {
            get 
            {
                return tenTacGia; 
            }
            set
            {
                if (tenTacGia != value)
                {
                    tenTacGia = value;
                    OnPropertyChanged("TenTacGia");
                }
            }
        }
        //Khai bao kiem tra xu ly item
        private TacGia selectedItem;
        public TacGia SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if(selectedItem!=value)
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                    ChangeInput();
                }
            }
        }
        //Khai bao luu item
        private ICommand saveCommand;
        private ICommand removeCommand;
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Khai bao xoa item
        public ICommand RemoveCommand
        {
            get
            {
                return removeCommand;
            }
            set { removeCommand = value; }
        }
        //Khai bao them item
        private ICommand addnewCommand;
        public ICommand AddNewCommand
        {
            get { return addnewCommand; }
            set { addnewCommand = value; }
        }
        //Khai bao sua item
        private ICommand editCommand;
        public ICommand EditCommand
        {
            get { return editCommand; }
            set { editCommand = value; }
        }
        //Ham khoi tao lop TheTacGia
        public TheTacGiaViewModel()
        {
            TenTacGia = "";
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));//Goi ham show thong bao khi luu
            RemoveCommand = new RelayCommand(new Action<object>(RemoveItems));//Goi ham xoa item khi xoa the tac gia
            AddNewCommand = new RelayCommand(new Action<object>(AddNewItems));//goi ham them item khi muon them the tac gia
            EditCommand = new RelayCommand(new Action<object>(EditItems));//Goi ham sua item khi muon sua the tac gia
            using (var db = new QLTVContext())
            {
                ListTacGia = new ObservableCollection<TacGia>(db.TacGias.ToArray());
            }
        }
        //Show thong bao khi luu thong tin tac gia
        public void ShowMessage(object obj)
        {
            //Neu da nhap ten tac gia thì thuc hien tiep tuc viec luu
            if (TenTacGia != "")
            {
                //Show thong bao cho nguoi dung chon neu chon yes thi tuc hien tiep no thi thoat
                MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu thông tin tác giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes thuc hien viec luu
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        MessageBox.Show("Thêm thành công : " + TenTacGia, "Thông báo");
                        TacGia tacgia = new TacGia();
                        tacgia.TenTacGia = TenTacGia;
                        db.TacGias.Add(tacgia);
                        db.SaveChanges();
                        //ListTacGia = new ObservableCollection<TacGia>(db.TacGias.ToArray());
                        ListTacGia.Add(tacgia);
                        TenTacGia = "";
                    }
                }
            }
            //Neu chua nhap du thong tin show ra thong bao 
            else
                MessageBox.Show("Bạn chưa nhập đũ thông tin!");
        }
        //Ham xoa item
        public void RemoveItems(object obj)
        {
            //Neu nguoi dung da chon item
            if (SelectedItem != null)
            {
                //Show len thong bao cho nguoi dung chon, neu yes tiep tuc, no thoat ham
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa tác giả không ? ", "Thông báo ?",MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes thuc hien ham xoa
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        TacGia tacGia = new TacGia();
                        tacGia = db.TacGias.FirstOrDefault(x => x.MaTacGia == SelectedItem.MaTacGia);
                        if (tacGia != null)
                        {
                            db.TacGias.Remove(tacGia);
                            db.SaveChanges();
                        }
                        ListTacGia.Remove(SelectedItem);
                    }
                }
            }
            //Neu nguoi dung chua chon item de xoa
            else
                MessageBox.Show("Bạn chưa chọn thẻ để xóa ! ", "Thông báo !");
        }
        //Them moi item
        public void AddNewItems(object obj)
        {
            TenTacGia = "";
        }
        //Sua item
        public void EditItems(object obj)
        {
            //Neu nguoi dung da chon item de sua thuc hien tiep viec sua
            if (SelectedItem != null)
            {
                //Show len thong bao cho nguoi dung chon, chon yes tiep tuc sua, no thoat ham
                MessageBoxResult result = MessageBox.Show("Bạn có muốn sữa thông tin tác giả không ?", "Thông báo !", MessageBoxButton.YesNo);
                //Neu nguoi dung chon yes thuc hien viec sua item
                if (result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        TacGia tacgia = new TacGia();
                        tacgia = db.TacGias.FirstOrDefault(x => x.MaTacGia == SelectedItem.MaTacGia);
                        if (tacgia != null)
                        {
                            tacgia.TenTacGia = TenTacGia;
                            ListTacGia = new ObservableCollection<TacGia>(db.TacGias.ToList());
                            db.SaveChanges();
                        }
                        MessageBox.Show("Sửa thành công");
                        TenTacGia = "";
                    }
                }
            }
            //Neu nguoi dung chua chon item de sua show len thong bao
            else
                MessageBox.Show("Bạn chưa chọn độc giả để sữa!", "Thông báo !");
            //using (var db = new QLTVContext())
            //{
            //    TacGia tacgia = new TacGia();
            //    tacgia = db.TacGias.FirstOrDefault(x => x.MaTacGia == SelectedItem.MaTacGia);
            //    if (tacgia != null)
            //    {
            //        tacgia.TenTacGia = TenTacGia;
            //        ListTacGia = new ObservableCollection<TacGia>(db.TacGias.ToList());
            //    }
            //    db.SaveChanges();
            //    MessageBox.Show("Sửa thành công");
            //}
        }
        private void ChangeInput()
        {
            if (SelectedItem != null)
                TenTacGia = SelectedItem.TenTacGia;
            else
                TenTacGia = "";
        }
    }
}
