using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    class ThePhieuTraViewModel : ViewModelBase
    {
        private DateTime ngayTra = DateTime.Now;//Khai bao ngay tra sach
        public DateTime NgayTra
        {
            get { return ngayTra; }
            set
            {
                ngayTra = value;
                OnPropertyChanged("NgayTra");
            }
        }
        //Khai bao ma doc gia
        private int maDocGia;
        public int MaDocGia
        {
            get { return maDocGia; }
            set
            {
                maDocGia = value;
                OnPropertyChanged("MaDocGia");
            }
        }
        //Khai bao ten doc gia
        private String tenDocGia;
        public String TenDocGia
        {
            get { return tenDocGia; }
            set
            {
                if (tenDocGia != value)
                {
                    tenDocGia = value;
                    OnPropertyChanged("TenDocGia");
                }
            }
        }
        //private int soNgayMuon;
        //public int SoNgayMuon
        //{
        //    get { return soNgayMuon; }
        //    set
        //    {
        //        if(soNgayMuon!=value)
        //        {
        //            soNgayMuon = value;
        //            OnPropertyChanged("SoNgayMuon");
        //        }
        //    }
        //}

        //private int soNgayTraTre;
        //public int SoNgayTraTre
        //{
        //    get { return soNgayTraTre; }
        //    set 
        //    {
        //         if (soNgayTraTre !=value )
        //         {
        //             soNgayTraTre = value;
        //             OnPropertyChanged("SoNgayTraTre");
        //         }
        //    }
        //}
        //public int tienPhat;
        //public double TienPhat
        //{
        //    get { return tienPhat; }
        //    set
        //    {
        //        if (tienPhat != value)
        //        {
        //            tienPhat = value;
        //            OnPropertyChanged("TienPhat");
        //        }
        //    }
        //}

        //Khai bao danh sach luu phieu muon
        private ObservableCollection<PhieuMuon> listLeft;
        public ObservableCollection<PhieuMuon> ListLeft
        {
            get { return listLeft; }
            set
            {
                if (listLeft != value)
                {
                    listLeft = value;
                    OnPropertyChanged("ListLeft");
                }
            }
        }
        //Kiem tra xu ly phieu muon
        private PhieuMuon selectedPhieuMuon;
        public PhieuMuon SelectedPhieuMuon
        {
            get { return selectedPhieuMuon; }
            set
            {
                if (selectedPhieuMuon != value)
                {
                    selectedPhieuMuon = value;
                    OnPropertyChanged("SelectedPhieuMuon");
                }
            }
        }
        //Khai bao list luu phieu tra
        private ObservableCollection<PhieuTra> listRight;
        public ObservableCollection<PhieuTra> ListRight
        {
            get { return listRight; }
            set
            {
                if (listRight != value)
                {
                    listRight = value;
                    OnPropertyChanged("ListRight");
                }
            }
        }
        //Kiem tra xu ly phieu tra
        private PhieuTra selectedPhieuTra;
        public PhieuTra SelectedPhieuTra
        {
            get { return selectedPhieuTra; }
            set
            {
                if (selectedPhieuTra != value)
                {
                    selectedPhieuTra = value;
                    OnPropertyChanged("SelectedPhieuTra");
                }
            }
        }
        //Khai bao luu item
        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Tim kiem doc gia
        private ICommand searchDocGiaCommand;
        public ICommand SearchDocGiaCommand
        {
            get { return searchDocGiaCommand; }
            set { searchDocGiaCommand = value; }
        }
        //Them item
        private ICommand addToRightCommand;

        public ICommand AddToRightCommand
        {
            get { return addToRightCommand; }
            set { addToRightCommand = value; }
        }
        //Xoa item
        private ICommand removeFromRightCommand;

        public ICommand RemoveFromRightCommand
        {
            get { return removeFromRightCommand; }
            set { removeFromRightCommand = value; }
        }
        //Ham khoi tao cua lop ThePhieuTra
        public ThePhieuTraViewModel()
        {
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            SearchDocGiaCommand = new RelayCommand(new Action<object>(SearchDocGia));
            AddToRightCommand = new RelayCommand(new Action<object>(AddToRight));
            RemoveFromRightCommand = new RelayCommand(new Action<object>(RemoveFromRight));

            ListLeft = new ObservableCollection<PhieuMuon>();
            ListRight = new ObservableCollection<PhieuTra>();
        }
        //Ham show thong bao khi luu doc gia
        public void ShowMessage(object obj)
        {
            //int i_ngaytratre=1000;
            //int i_ngayduocmuon=0;
            //int i_ma = 0;

            //MessageBox.Show("Tra Thanh Cong");
            //using (var db = new QLTVContext())
            //{
            //    PhieuMuon phieuMuon = new PhieuMuon();
            //    PhieuTra phieutra = new PhieuTra();
            //    phieutra.PhieuMuon.MaPhieuMuon = i_ma;
            //    phieutra.NgayTra = DateTime.Now;
            //    phieutra.SoNgayMuon = DateTime.Now.Day - phieuMuon.NgayMuon.Day;// so trong trong 1 thang 
            //    phieutra.SoNgayTraTre = phieutra.SoNgayTraTre -i_ngayduocmuon;// tham so ?!!!
            //    phieutra.TienPhat = phieutra.SoNgayTraTre * i_ngaytratre;// tham so tien ;
            //    db.PhieuTras.Add (phieutra);
            //    db.SaveChanges();
            //}
            int tongTienPhat = 0;
            int tongNo=0;
            using (var db = new QLTVContext())
            {
                foreach(var phieuTra in ListRight)
                {
                    db.PhieuTras.Add(phieuTra);
                    var phieuMuon = db.PhieuMuons.First(x => x.MaPhieuMuon == phieuTra.MaPhieuMuon);
                    phieuMuon.DaTra = true;
                    var cuonSach = db.CuonSachs.First(x => x.MaCuonSach == phieuMuon.MaCuonSach);
                    cuonSach.TinhTrangSach = false;
                    tongTienPhat += phieuTra.TienPhat;
                }
                var docGia = db.DocGias.First(x => x.MaDocGia == MaDocGia);
                tongNo = docGia.TongNo+ tongTienPhat;
                docGia.TongNo = tongNo;
                db.SaveChanges();
            }
            MessageBox.Show(" Trả sách thành công\n Tiền phạt kì này: " + tongTienPhat + "\n Tổng nợ:" + tongNo);
            var e = Application.Current.Windows.GetEnumerator();
            while (e.MoveNext())
            {
                Window value = e.Current as Window;
                if (value.Title == "PHIẾU TRẢ SÁCH")
                    value.Close();
            }
        }
        DocGia docGiaViewModel;
        //Ham search doc gia 
        public void SearchDocGia(object obj)
        {
            using (var db = new QLTVContext())
            {
                //DocGia docGiaViewModel;// = new DocGia();
                docGiaViewModel = db.DocGias.FirstOrDefault(x => x.MaDocGia == MaDocGia);
                if (docGiaViewModel == null)
                {
                    MessageBox.Show("Không tìm thấy độc giả");
                    return;
                }
                TenDocGia = docGiaViewModel.HoTen;
                ListLeft = new ObservableCollection<PhieuMuon>(
                    db.PhieuMuons.Include("CuonSach.DauSach").Where(x => x.MaDocGia == MaDocGia && x.DaTra == false).ToList());
            }
        }
        //Ham them doc gia
        private void AddToRight(object obj)
        {
            if (SelectedPhieuMuon == null)
                return;
            PhieuTra phieuTra = new PhieuTra();
            phieuTra.PhieuMuon = SelectedPhieuMuon;
            phieuTra.MaPhieuMuon = SelectedPhieuMuon.MaPhieuMuon;
            phieuTra.NgayTra = NgayTra;
            phieuTra.SoNgayMuon = (NgayTra - SelectedPhieuMuon.NgayMuon).Days;
            int soNgayMuonToiDa;
            int tienPhat;
            using (var db = new QLTVContext())
            {
                soNgayMuonToiDa = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa").GiaTri;
                tienPhat = db.ThamSos.First(x => x.TenThamSo == "TienPhat").GiaTri;
            }
            int soNgayTraTre = phieuTra.SoNgayMuon - soNgayMuonToiDa;
            if (soNgayTraTre >= 0)
                phieuTra.SoNgayTraTre = soNgayTraTre;
            else
                phieuTra.SoNgayTraTre = 0;
            phieuTra.TienPhat = phieuTra.SoNgayTraTre * tienPhat;
            ListLeft.Remove(SelectedPhieuMuon);
            ListRight.Add(phieuTra);
        }
        //Ham xoa doc gia
        private void RemoveFromRight(object obj)
        {
            if (SelectedPhieuTra == null)
                return;
            PhieuMuon phieuMuon = SelectedPhieuTra.PhieuMuon;
            //phieuMuon.MaPhieuMuon = SelectedPhieuTra.MaPhieuMuon;
            ListRight.Remove(SelectedPhieuTra);
            ListLeft.Add(phieuMuon);
        }
    }
}
