using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    class TheThamSoViewModel : ViewModelBase
    {
        //Khai bao tupoi doc gia toi thieu
        private int tuoiDocGiaToiThieu;
        public int TuoiDocGiaToiThieu
        {
            get { return tuoiDocGiaToiThieu; }
            set
            {
                if (tuoiDocGiaToiThieu != value)
                {
                    tuoiDocGiaToiThieu = value;
                    OnPropertyChanged("TuoiDocGiaToiThieu");
                }
            }
        }
        //Khai bao tuoi doc gia toi da
        private int tuoiDocGiaToiDa;
        public int TuoiDocGiaToiDa
        {
            get { return tuoiDocGiaToiDa; }
            set
            {
                if (tuoiDocGiaToiDa != value)
                {
                    tuoiDocGiaToiDa = value;
                    OnPropertyChanged("TuoiDocGiaToiDa");
                }
            }
        }
        //Khai bao thoi han the
        private int soThangThoiHanThe;
        public int SoThangThoiHanThe
        {
            get { return soThangThoiHanThe; }
            set
            {
                if (soThangThoiHanThe != value)
                {
                    soThangThoiHanThe = value;
                    OnPropertyChanged("SoThangThoiHanThe");
                }
            }
        }
        //Khai bao nam xuat ban
        private int soNamThoiHanXuatBan;
        public int SoNamThoiHanXuatBan
        {
            get { return soNamThoiHanXuatBan; }
            set
            {
                if (soNamThoiHanXuatBan != value)
                {
                    soNamThoiHanXuatBan = value;
                    OnPropertyChanged("SoNamThoiHanXuatBan");
                }
            }
        }
        //Khai bao sach muon toi da
        private int soSachMuonToiDa;
        public int SoSachMuonToiDa
        {
            get { return soSachMuonToiDa; }
            set
            {
                if (soSachMuonToiDa != value)
                {
                    soSachMuonToiDa = value;
                    OnPropertyChanged("SoSachMuonToiDa");
                }
            }
        }
        //Khai bao so ngay muon toi da
        private int soNgayMuonToiDa;
        public int SoNgayMuonToiDa
        {
            get { return soNgayMuonToiDa; }
            set
            {
                if (soNgayMuonToiDa != value)
                {
                    soNgayMuonToiDa = value;
                    OnPropertyChanged("SoNgayMuonToiDa");
                }
            }
        }
        //Khai bao tien phat khi tra muon
        private int tienPhat;
        public int TienPhat
        {
            get { return tienPhat; }
            set
            {
                if (tienPhat != value)
                {
                    tienPhat = value;
                    OnPropertyChanged("TienPhat");
                }
            }
        }
        //Khai bao quy dinh thu tien
        private bool apDungQDTienThu;
        public bool ApDungQDTienThu
        {
            get { return apDungQDTienThu; }
            set
            {
                if (apDungQDTienThu != value)
                {
                    apDungQDTienThu = value;
                    OnPropertyChanged("ApDungQDTienThu");
                }
            }
        }
        //Luu lai item
        private ICommand saveCommand;
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
        //Ham khoi tao TheThamSo
        public TheThamSoViewModel()
        {
            //TenThamSo="";
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            //DefaultCommand = new RelayCommand(new Action<object>(Default));
            //nhan thong tin tu cac textbox de cho vao bang
            using (var db = new QLTVContext())
            {
                TuoiDocGiaToiThieu = db.ThamSos.First(x => x.TenThamSo == "TuoiDocGiaToiThieu").GiaTri;
                TuoiDocGiaToiDa = db.ThamSos.First(x => x.TenThamSo == "TuoiDocGiaToiDa").GiaTri;
                SoThangThoiHanThe = db.ThamSos.First(x => x.TenThamSo == "SoThangThoiHanThe").GiaTri;
                SoNamThoiHanXuatBan = db.ThamSos.First(x => x.TenThamSo == "SoNamThoiHanXuatBan").GiaTri;
                SoSachMuonToiDa = db.ThamSos.First(x => x.TenThamSo == "SoSachMuonToiDa").GiaTri;
                SoNgayMuonToiDa = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa").GiaTri;
                //TODO: Tien phat va Ap dung quy dinh
            }
        }
        //Hamf luu lai thong tin va Show len thong bao khi luu thanh cong
        public void ShowMessage(object obj)
        {  
            using (var db = new QLTVContext())
            {
                ThamSo thamSo = db.ThamSos.First(x => x.TenThamSo == "TuoiDocGiaToiThieu");
                thamSo.GiaTri = TuoiDocGiaToiThieu;
                thamSo = db.ThamSos.First(x => x.TenThamSo == "TuoiDocGiaToiDa");
                thamSo.GiaTri = TuoiDocGiaToiDa;
                thamSo = db.ThamSos.First(x => x.TenThamSo == "SoThangThoiHanThe");
                thamSo.GiaTri = SoThangThoiHanThe;
                thamSo = db.ThamSos.First(x => x.TenThamSo == "SoNamThoiHanXuatBan");
                thamSo.GiaTri = SoNamThoiHanXuatBan;
                thamSo = db.ThamSos.First(x => x.TenThamSo == "SoSachMuonToiDa");
                thamSo.GiaTri = SoSachMuonToiDa;
                thamSo = db.ThamSos.First(x => x.TenThamSo == "SoNgayMuonToiDa");
                thamSo.GiaTri = SoNgayMuonToiDa;
                db.SaveChanges();
            }
            MessageBox.Show("Đã lưu thay đổi!");
        }
    }
}
