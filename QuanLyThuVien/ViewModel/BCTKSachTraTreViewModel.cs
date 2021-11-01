
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
    class BCTKSachTraTreViewModel : ViewModelBase
    {
        private ObservableCollection<BCTKSachTraTre> listTraTre;
        // tao list bao cao thong ke sach tra tre
        // khai bao ham mac dinh cua list
        public ObservableCollection<BCTKSachTraTre> ListTraTre
        {
            get { return listTraTre; }
            set
            {
                if (listTraTre != value)
                {
                    listTraTre = value;
                    OnPropertyChanged("ListTraTre");
                }
            }
        }
        //private ObservableCollection<PhieuMuon> listPhieuMuon;
        //public ObservableCollection<PhieuMuon> ListPhieuMuon
        //{
        //    get { return listPhieuMuon; }
        //    set
        //    {
        //        listPhieuMuon = value;
        //      //  OnPropertyChanged("ListTraTre");
        //    }
        //}
        //private ObservableCollection<BCTKSachTraTreCT> listTraTrect;
        //public ObservableCollection<BCTKSachTraTreCT> ListTraTrect
        //{
        //    get { return listTraTrect; }
        //    set
        //    {
        //        listTraTrect = value;
        //        OnPropertyChanged("ListTraTreCT");
        //    }
        //}
        ////private ObservableCollection<PhieuMuon> listMuon;
        ////public ObservableCollection<PhieuMuon> ListMuon
        ////{
        ////    get { return listMuon; }
        ////    set
        ////    {
        ////        listMuon = value;
        ////    }
        ////}
        //private DateTime ngayLap;
        //public DateTime NgayLap
        //{
        //    get { return ngayLap; }
        //    set
        //    {
        //        ngayLap = DateTime.Now;
        //        OnPropertyChanged("NgayLap");
        //    }
        //}
        private DateTime ngayBaoCao = DateTime.Today;
        // Bien ngay bao cao = ngay hien tai
        public DateTime NgayBaoCao
        {
            get { return ngayBaoCao; }
            set
            {
                ngayBaoCao = DateTime.Now;
                OnPropertyChanged("NgayBaoCao");
            }
        }
        ////private int maCuonSach;
        ////public int MaCuonSach
        ////{
        ////    get { return maCuonSach; }
        ////    set
        ////    {
        ////        maCuonSach = value;
        ////        OnPropertyChanged("MaCuonSach");
        ////    }
        ////}
        ////private int soNgayTra
        //private ICommand saveCommand;

        //public ICommand SaveCommand
        //{
        //    get { return saveCommand; }
        //    set { saveCommand = value; }
        //}
        //private ICommand printCommand;

        //public ICommand PrintCommand
        //{
        //    get { return printCommand; }
        //    set { printCommand = value; }
        //}

        // Ham goi bat su kien bottom thongke
        private ICommand actionCommand;

        public ICommand ActionCommand
        {
            get { return actionCommand; }
            set { actionCommand = value; }
        }
        public BCTKSachTraTreViewModel()
        {
            ActionCommand = new RelayCommand(new Action<object>(ThongKe));

            ListTraTre = new ObservableCollection<BCTKSachTraTre>();
            //PrintCommand = new RelayCommand(new Action<object>(Print));
            //using (var db = new QLTVContext())
            //{
            //    ListTraTre = new ObservableCollection<BCTKSachTraTre>(db.BCTraTres.ToList());
            //    //ListTraTrect = new ObservableCollection<BCTKSachTraTreCT>(db.BCTraTreCTs.ToList());
            //    //ListTraTrect.Clear();

            //}
        }
        // ham thon cac sach tra tre
        private void ThongKe(object obj)
        {
            ListTraTre.Clear();
            using(var db = new QLTVContext())
            {
                int SoNgayMuonToiDa = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa").GiaTri;
                DateTime day=DateTime.Today.AddDays(-SoNgayMuonToiDa);
                var list =db.PhieuMuons.Include("CuonSach").Include("CuonSach.DauSach").Where(x => x.DaTra == false && x.NgayMuon < day).ToList();
                foreach (var item in list)
                {
                    BCTKSachTraTre bc = new BCTKSachTraTre();
                    bc.NgayBaoCao = NgayBaoCao;
                    bc.NgayMuon = item.NgayMuon;
                    bc.SoNgayTraTre = (NgayBaoCao-bc.NgayMuon).Days;
                    bc.CuonSach = item.CuonSach;
                    ListTraTre.Add(bc);
                    db.BCTraTres.Add(bc);
                }
                db.SaveChanges();
            }
        }


        //private void ShowMessage(object obj)
        //{
        //    using (var db = new QLTVContext())
        //    {
        //        BCTKSachTraTre bc = new BCTKSachTraTre();
        //        bc.NgayLap = DateTime.Now;
        //        bc.NgayBaoCao = NgayBaoCao;
        //        db.BCTraTres.Add(bc);
        //        db.SaveChanges();
        //        AddChiTietTratre(db, bc);
        //    }
        //}

        //private void AddChiTietTratre(QLTVContext db, BCTKSachTraTre bc)
        //{
        //    int songayduocmuon = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa").GiaTri;
        //    // DateTime songay = new DateTime(0,0,songayduocmuon);
        //    ListPhieuMuon = new ObservableCollection<PhieuMuon>(db.PhieuMuons.Include("DocGia").ToList());
        //    PhieuMuon pm;
        //    List<BCTKSachTraTreCT> list = new List<BCTKSachTraTreCT>();
        //    for (int i = 0; i < db.PhieuMuons.Count(); i++)
        //    {
        //       // pm = new PhieuMuon();
        //        pm = ListPhieuMuon.ElementAt(0);
        //        TimeSpan day = NgayBaoCao - pm.NgayMuon;
        //        TimeSpan thehethan = NgayBaoCao - pm.DocGia.NgayHetHan;
        //        if ((pm.CuonSach.TinhTrangSach == true) || (thehethan.Days > 0))
        //        {
        //            BCTKSachTraTreCT ct = new BCTKSachTraTreCT();
        //            ct.MaBCTKSachTraTre = bc.MaBCTKSachTraTre;
        //            ct.MaCuonSach = pm.CuonSach.MaCuonSach;
        //            ct.NgayMuon = pm.NgayMuon;
        //            ct.SoNgayTraTre = day.Days - songayduocmuon;
        //            if (thehethan.Days > 0)
        //                ct.GhiChu = "Thẻ Đọc Giả Hết Hạn!";
        //            list.Add(ct);
        //           // db.BCTraTreCTs.Add(ct);
        //            db.SaveChanges();

        //        }
        //        //ListTraTrect = new ObservableCollection<BCTKSachTraTreCT>(db.BCTraTreCTs.Include("DauSach").ToList());
        //    }
        //}
        //private void Print(object obj)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
