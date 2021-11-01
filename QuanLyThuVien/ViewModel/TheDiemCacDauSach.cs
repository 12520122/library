using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class TheDiemCacDauSach : ViewModelBase
    {
        public class DanhSachCacDauSach : ViewModelBase
        {
            // ham tao listDoiTuong
            private ObservableCollection<String> lstdoituong;
            public ObservableCollection<String> Lstdoituong
            {
                get { return lstdoituong; }
                set
                {
                    if (lstdoituong != value)
                    {
                        lstdoituong = value;
                        OnPropertyChanged("Lstdoituong");
                    }
                }
            }
            // Ham goi TenSach 
            private string tenSach;
            public string TenSach
            {
                get { return tenSach; }
                set
                {
                    if (tenSach != value)
                    {
                        tenSach = value;
                        OnPropertyChanged("TenSach");
                    }
                }
            }
            //Ham goi SoLuotMuon
            private int soluotMuon;
            public int SoLuotMuon
            {
                get { return soluotMuon; }
                set
                {
                    if (soluotMuon != value)
                    {
                        soluotMuon = value;
                        OnPropertyChanged("SoLuotMuon");
                    }
                }
            }
            /// <summary>
            ///  Hàm Gọi Diem So
            /// </summary>
            private int diemSo;
            public int DiemSo
            {
                get { return diemSo; }
                set
                {
                    if (diemSo != value)
                    {
                        diemSo = value;
                        OnPropertyChanged("DiemSo");
                    }
                }
            }
        }
        // Ham goi ListDiemDauSach
        private ObservableCollection<DanhSachCacDauSach> listDiemDauSach;
        public ObservableCollection<DanhSachCacDauSach> ListDiemDauSach
        {
            get { return listDiemDauSach; }
            set
            {
                listDiemDauSach = value;
                OnPropertyChanged("ListDiemDauSach");
            }
        }
        // Tao bien tam list danh sach dau sach
        List<DanhSachCacDauSach> DSSachDauSach = new List<DanhSachCacDauSach>();
        
        public TheDiemCacDauSach()
        {
            // Lay so luot muon va tinh diem cua moi dau sach
            using (var db = new QLTVContext())
            {
                int SoDocGia = db.DocGias.Count();
                int SoLuotMuon = 0;
                foreach (DauSach DS in db.DauSachs.ToList())
                {
                    int DiemSo = 0;
                    foreach (CuonSach CS in db.CuonSachs.ToList())
                    {
                        if (CS.MaDauSach == DS.MaDauSach && CS.TinhTrangSach == true)
                        {
                            SoLuotMuon++;
                        }
                    }
                    if (SoLuotMuon > 0)
                    {
                        DiemSo = (5 * SoLuotMuon) / SoDocGia;

                    }
                    DanhSachCacDauSach Ds = new DanhSachCacDauSach();
                    Ds.TenSach = DS.TenDauSach;
                    Ds.SoLuotMuon = SoLuotMuon;
                    Ds.DiemSo = DiemSo;
                    Ds.Lstdoituong = new ObservableCollection<string>();
                    for (int i = 0; i < DiemSo; i++)
                    {
                        Ds.Lstdoituong.Add("");
                    }
                    DSSachDauSach.Add(Ds);

                }
            }

            ListDiemDauSach = new ObservableCollection<DanhSachCacDauSach>(DSSachDauSach.ToList());
        }

    }
}
