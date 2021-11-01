using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class ThongKeSachCuMoi : ViewModelBase
    {
        // Khoi tao class voi cac thuoc tinh o duoi, cac thuoc tinh do no se lien ket voi cac du lien o from cua no
        public class DanhSachMoiCu : ViewModelBase
        {
            private string tenSach;
            public string TenSach
            {
                get { return tenSach; }
                set
                {
                    if(tenSach != value)
                    {
                        tenSach = value;
                        OnPropertyChanged("TenSach");
                    }
                }
            }
            private int slSachCu;
            public int SLSachCu
            {
                get {return slSachCu;}
                set
                {
                    if(slSachCu != value)
                    {
                        slSachCu = value;
                        OnPropertyChanged("SLSachCu");
                    }
                }
            }
            private int slSachMoi;
            public int SLSachMoi
            {
                get { return slSachMoi; }
                set
                {
                    if(slSachMoi != value)
                    {
                        slSachMoi = value;
                        OnPropertyChanged("SLSachMoi");
                    }
                }
            }
            private int hieuSo;
            public int HieuSo
            {
                get { return hieuSo; }
                set
                {
                    if(hieuSo != value)
                    {
                        hieuSo = value;
                        OnPropertyChanged("HieuSo");
                    }
                }
            }
        };
        // ham lien ket voi datagird de dua cac thong tin 
        private ObservableCollection<DanhSachMoiCu> listSachCuMoi;
        public ObservableCollection<DanhSachMoiCu> ListSachCuMoi
        {
            get { return listSachCuMoi; }
            set
            {
                listSachCuMoi = value;
                OnPropertyChanged("ListSachCuMoi");
            }
        }

        List<DanhSachMoiCu> ListDSCuMoi = new List<DanhSachMoiCu>();
        // Ham nay se thong ke ra so sac cu va moi theo tung ten dau sach.
        public ThongKeSachCuMoi()
        {
            using (var db = new QLTVContext())
            {
                foreach(DauSach DS in db.DauSachs.ToList())
                {
                    int ix = 0;
                    int iy = 0;
                    int ih = 0;
                    foreach(CuonSach CS in db.CuonSachs.ToList())
                    {
                        if(CS.MaDauSach == DS.MaDauSach)
                        {
                            if (DateTime.Today.Year - DS.NamXB > 10)
                                ix++;
                            else if (DateTime.Today.Year - DS.NamXB <= 10)
                                iy++;
                        }
                    }
                    ih = ix - iy;
                    DanhSachMoiCu dsmc = new DanhSachMoiCu();
                    dsmc.TenSach = DS.TenDauSach;
                    dsmc.SLSachCu = ix;
                    dsmc.SLSachMoi = iy;
                    dsmc.HieuSo = ih;
                    ListDSCuMoi.Add(dsmc);
                }
            }
            ListSachCuMoi = new ObservableCollection<DanhSachMoiCu>(ListDSCuMoi.ToList());
        }
    }
}
