using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    class TheDocGiaViewModel : ViewModelBase
    {
        private String hoTen;

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
        private string loaiDocGia;
        public string LoaiDocGia
        {
            get { return loaiDocGia; }
            set { loaiDocGia = value; }
        }
        private String diaChi;
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
        private String email;
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
        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        }
        //private DateTime ngayLapThe;
        //public DateTime NgayLapThe
        //{
        //    get { return ngayLapThe; }
        //    set
        //    {
        //        ngayLapThe = value;
        //    }
        //}
        //private DateTime ngayHetHan;
        //public DateTime NgayHetHan
        //{
        //    get 
        //    {
        //        return ngayHetHan; 
        //    }
        //    set 
        //    {
                
        //        ngayHetHan = value;
        //    }
        //}
        private int tongNo;
        public int TongNo
        {
            get { return tongNo; }
            set { tongNo = value; }
        }
        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        public TheDocGiaViewModel()
        {
            HoTen="ABC";
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
        }
        public void ShowMessage(object obj)
        {
            MessageBox.Show(HoTen);
            using (var db = new QLTVContext())
            {
                DocGia docGia = new DocGia();
                docGia.HoTen = HoTen;
                docGia.LoaiDocGia = LoaiDocGia;
                docGia.NgaySinh = DateTime.Now;
                docGia.DiaChi = DiaChi;
                docGia.Email = Email;
                docGia.NgayLapThe = DateTime.Now;
                docGia.NgayHetHan = DateTime.Now;
                docGia.TongNo = TongNo;
                db.DocGias.Add(docGia);
                db.SaveChanges();
            }
        }
    }
}
