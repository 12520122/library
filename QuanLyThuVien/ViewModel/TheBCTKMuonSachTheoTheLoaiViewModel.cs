using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    class TheBCTKMuonSachTheoTheLoaiModel : ViewModelBase, IDataErrorInfo
    {
        //private ObservableCollection<BCTKMuonSachTheoTheLoai> listBC;
        //public ObservableCollection<BCTKMuonSachTheoTheLoai> ListBC
        //{
        //    get { return listBC; }
        //    set
        //    {
        //        listBC = value;
        //        OnPropertyChanged("ListBC");
        //    }
        //}

        // Tao tao mot list bao cao thong ke muon sach theo the loai
        private ObservableCollection<CT_BCTKMuonSachTheTheLoai> listBCct;

        // Ham : tra ve gia tri va lay gia tri 
        // Doi so truyen vao: khong co
        // Kieu tra ve: 
        public ObservableCollection<CT_BCTKMuonSachTheTheLoai> ListBCct
        {
            get { return listBCct; }
            set
            {
                listBCct = value;
                OnPropertyChanged("ListBCct");
            }
        }
        //private ObservableCollection<LoaiSach> listLoaiSach;
        //public ObservableCollection<LoaiSach> ListLoaiSach

        // {
        //    get { return listLoaiSach; }
        //    set
        //    {
        //        listLoaiSach = value;
        //        OnPropertyChanged("ListLoaiSach");
        //    }
        //}
        //private DateTime ngayLap;
        //public DateTime NgayLap
        //{
        //    get { return ngayLap; }
        //    set
        //    {
        //        ngayLap = DateTime.Now;
        //    }
        //}


        // Tao list voi nhung thang: listThang
        private List<int> listThang;

        // Ham ListThang: tra ve gia tri va lay gia tri cua listThang
        // Doi so truyen vao: khong co
        // Kieu tra ve: List<int>
        public List<int> ListThang
        {
            get { return listThang; }
            set
            {
                if (listThang != value)
                {
                    listThang = value;
                    OnPropertyChanged("ListThang");
                }
            }
        }

        // Ten bien: selectedthang
        // Kieu du lieu: int
        private int selectedthang;

        // Ham SelectedThang : tra ve gia tri va lay gia tri cua bien selectedthang
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int SeclectedThang
        {
            get { return selectedthang; }
            set
            {
                if (selectedthang != value)
                {
                    selectedthang = value;
                    OnPropertyChanged("SelectedThang");
                }
            }
        }

        // Ten bien: year
        // Kieu du lieu: int
        private int year;

        // Ham Year : tra ve gia tri va lay gia tri year
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    OnPropertyChanged("Year");
                }
            }
        }

        // Ten bien: tongso
        // Kieu du lieu: int
        private int tongSo;


        // Ham TongSo : tra ve gia tri va lay gia tri tongso
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int TongSo
        {
            get { return tongSo; }
            set
            {
                if (tongSo != value)
                {
                    tongSo = value;
                    OnPropertyChanged("TongSo");
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
                    case "Year":
                        if (Year <= 0)
                        {
                            result = "Năm không hợp lệ!!!";
                        }
                        break;

                    default:
                        break;
                }
                return result;
            }
        }
        #endregion
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

        // Ten bien: actionCommand
        // kieu du lieu: ICommand
        private ICommand actionCommand;


        // Ham ActionCommand: tra ve gia tri va lay gia tri actionCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand ActionCommand
        {
            get { return actionCommand; }
            set { actionCommand = value; }
        }

        // Ham TheBCTKMuonSachTheoTheLoaiModel(): ham khoi tao mac dinh cua class
        // Doi so truyen vao: khong co
        // Kieu tra ve: khong co
        public TheBCTKMuonSachTheoTheLoaiModel()
        {
            ActionCommand = new RelayCommand(new Action<object>(ThongKe));
            listBCct = new ObservableCollection<CT_BCTKMuonSachTheTheLoai>();
            ListThang = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            SeclectedThang = ListThang.FirstOrDefault();
            //SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            //PrintCommand = new RelayCommand(new Action<object>(Print));
            //using (var db = new QLTVContext())
            //{
            //    ListBC = new ObservableCollection<BCTKMuonSachTheoTheLoai>(db.BCTheLoais.ToList());
            //    listBCct = new ObservableCollection<CT_BCTKMuonSachTheTheLoai>(db.CT_BCMTheLoais.ToList());
            //    listLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
            //    //ListBCct.Clear();
            //    //ListMuon.Clear();

            //}
        }
        //public void ShowMessage(object obj)
        //{

        //    using (var db = new QLTVContext())
        //    {
        //        BCTKMuonSachTheoTheLoai bc;
        //        bc = db.BCTheLoais.FirstOrDefault(x => x.Thang == Thang&&x.Nam==Year);
        //        if (bc == null)
        //        {
        //            bc = new BCTKMuonSachTheoTheLoai();
        //            bc.NgayLap = DateTime.Now;
        //            bc.Thang = Thang;
        //            bc.Nam = Year;
        //            bc.TongSo = 0;

        //            db.BCTheLoais.Add(bc);
        //            db.SaveChanges();

        //            AddCT_BC(db, bc, year);
        //            listBCct = new ObservableCollection<CT_BCTKMuonSachTheTheLoai>(db.CT_BCMTheLoais.ToList());
        //        }




        //    }
        //}
        //private void AddCT_BC(QLTVContext db,BCTKMuonSachTheoTheLoai bc,int year)
        //{
        //    listLoaiSach = new ObservableCollection<LoaiSach>(db.LoaiSachs.ToList());
        //    int so = listLoaiSach.Count();
        //    for (int i = 0; i < so; i++)
        //    {
        //        LoaiSach theloai = new LoaiSach();
        //        theloai = listLoaiSach.ElementAt(i);
        //       // listLoaiSach.RemoveAt(0);
        //        if (theloai != null)
        //        {
        //            CT_BCTKMuonSachTheTheLoai ct = new CT_BCTKMuonSachTheTheLoai();
        //            ct.BCTKMS = bc.MaBCTKMS;
        //            //  ct.MaTheLoai = theloai.MaLoaiSach;
        //            ct.SoLuot = db.PhieuMuons.Include("TheLoai").Where(x => x.CuonSach.DauSach.MaLoaiSach == theloai.MaLoaiSach && x.NgayMuon.Month == bc.Thang &&x.NgayMuon.Year==year).Count();
        //            // db.PhieuMuons.Include("TheLoai").Where(x=>x.NgayMuon.Month==bc.NgayLap.Month && x.CuonSach.DauSach.MaLoaiSach==ct.MaTheLoai).Count();
        //            TongSo = db.PhieuMuons.Where(x => x.NgayMuon.Month == bc.NgayLap.Month).Count();

        //            ct.Tile = (float)(ct.SoLuot / TongSo);

        //            ct.LoaiSach = theloai;
        //            // ct.BCTKMuonTheoTheLoai = bc;
        //            ct.MaTheLoai = theloai.MaLoaiSach;
        //            ct.LoaiSach = theloai;

        //            db.CT_BCMTheLoais.Add(ct);
        //            db.SaveChanges();

        //        }

        //    }

        //}
        //private void Print(object obj)
        //{
        //    using (System.IO.StreamWriter file = new System.IO.StreamWriter("fileBaoCaoLoaiSach.txt"))
        //    {
        //        foreach (object value in ListBCct.ToArray())
        //        {
        //            file.WriteLine(value);
        //        }
        //        file.Close();
        //    }
        //    MessageBox.Show("Lưu Thành Công");
        //}

        // Ham ThongKe : Thong ke sach theo the loai
        // Doi so truyen vao: khong co
        // Kieu tra ve: void
        private void ThongKe(object obj)
        {
            listBCct.Clear();
            using (var db = new QLTVContext())
            {
                var listLoaiSach = db.LoaiSachs.Include("DauSachs").ToList();
                BCTKMuonSachTheoTheLoai bc = new BCTKMuonSachTheoTheLoai();
                bc.Thang = SeclectedThang;
                bc.Nam = Year;
                int tongSoLuot = 0;
                List<CT_BCTKMuonSachTheTheLoai> listCT = new List<CT_BCTKMuonSachTheTheLoai>();
                foreach (var loaiSach in listLoaiSach)
                {
                    int cnt = 0;
                    foreach (var dauSach in loaiSach.DauSachs)
                    {
                        cnt = db.PhieuMuons.Where(x => x.CuonSach.MaDauSach == dauSach.MaDauSach).Count();
                    }
                    tongSoLuot += cnt;
                    CT_BCTKMuonSachTheTheLoai ct = new CT_BCTKMuonSachTheTheLoai();
                    //var tenLS = db.LoaiSachs.Where(x=>x.MaLoaiSach=lo)
                    ct.LoaiSach = loaiSach;
                    ct.BCTKMuonTheoTheLoai = bc;
                    ct.SoLuot = cnt;
                    listCT.Add(ct);
                }

                bc.TongSo = tongSoLuot;
                TongSo = tongSoLuot;
                foreach (var item in listCT)
                {
                    item.TiLe = (double)item.SoLuot / tongSoLuot;
                    listBCct.Add(item);
                    bc.CT_BCTKMuonSachTheTheLoais.Add(item);
                    db.CT_BCMTheLoais.Add(item);
                }
                //db.SaveChanges();
            }
        }

    }
}
