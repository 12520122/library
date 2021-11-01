using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    public class TheDaoHanMuonSach : ViewModelBase
    {
        // Khai bao bien maPhieuMuon
        private int maPhieuMuon;
        // lien ket voi textbox Maphieumuon cua form
        public int MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set
            {
                if (maPhieuMuon != value)
                {
                    maPhieuMuon = value;
                    OnPropertyChanged("MaPhieuMuon");
                }
            }
        }
        //Khai bao bien ma Doc gia
        private int maDocGia;
        // lien ket voi textbox MaDocGia cua form
        public int MaDocGia
        {
            get { return maDocGia; }
            set
            {
                if (maDocGia != value)
                {
                    maDocGia = value;
                    OnPropertyChanged("MaDocGia");
                }
            }
        }
        // Khai bao bien maCuonSach
        private int maCuonSach;
        // lien ket voi textbox MaCuonSach cua form
        public int MaCuonSach
        {
            get { return maCuonSach; }
            set
            {
                if (maCuonSach != value)
                {
                    maCuonSach = value;
                    OnPropertyChanged("MaCuonSach");
                }
            }
        }
        // Khai bao bien ngayMuon
        private DateTime ngayMuon;
        // lien ket voi DatePicker NgayMuon cua form
        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set
            {
                if(ngayMuon != value)
                {
                    ngayMuon = value;
                    OnPropertyChanged("NgayMuon");
                }
            }
        }
        // Khai bao bien ngayHetHan
        private DateTime ngayHetHan;
        // lien ket voi DatePicker NgayHetHan cua form
        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set
            {
                if (ngayHetHan != value)
                {
                    ngayHetHan = value;
                    OnPropertyChanged("NgayHetHan");
                }
            }
        }
        // Ham lien ket voi bottom tim kiem
        private ICommand serchPhieuMuonCommand;
        public ICommand SearchPhieuMuonCommand
        {
            get { return serchPhieuMuonCommand; }
            set { serchPhieuMuonCommand = value; }
        }
        // Ten bien: giaHan
        // Kieu du lieu: ICommand
        private ICommand giaHan;

        // Ham GiaHan: tra ve gia tri va lay gia tri cua bien addCuonSachCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommand
        public ICommand GiaHan
        {
            get { return giaHan; }
            set { giaHan = value; }
        }

        public TheDaoHanMuonSach()
        {
            MaDocGia = 0;
            SearchPhieuMuonCommand = new RelayCommand(new Action<object>(SearPhieuMuon));
            GiaHan = new RelayCommand(new Action<object>(daoHan));
        }
        PhieuMuon phieumuon = new PhieuMuon();
        // Ham tim kiem phieu muon theo MaPhieuMuon co hay khong
        // Neu co thi dua ra thong tin
        public void SearPhieuMuon(object obj)
        {
            phieumuon = new PhieuMuon();
            using (var db = new QLTVContext())
            {
                foreach(PhieuMuon PM in db.PhieuMuons.ToList())
                {
                    if(PM.MaPhieuMuon == MaPhieuMuon)
                    {
                        phieumuon = PM;
                    }
                }

                if(phieumuon.MaPhieuMuon == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn sách !", "Thông báo !");
                }
                else
                {
                    MaDocGia = phieumuon.MaDocGia;
                    MaCuonSach = phieumuon.MaCuonSach;
                    NgayMuon = phieumuon.NgayMuon;
                    NgayHetHan = phieumuon.NgayHetHan;
                    if (phieumuon.NgayHetHan < DateTime.Today)
                    {
                        MessageBox.Show("Phiếu mượn này đã hết hạn !", "Thông báo !");
                    }
                    else
                    {
                        MessageBox.Show("Phiếu mượn này còn hạn ! ", "Thông báo !");
                    }
                }
            }
        }
        // Ham nay se dao han them 1 so ngay vao thuoc tinh NgayHetHan
        public void daoHan(object obj)
        {
            if(phieumuon.MaPhieuMuon != 0)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn gia hạn thêm 30 ngày sách đang mượn không !","Thông báo",MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    using (var db = new QLTVContext())
                    {
                        PhieuMuon pm = new PhieuMuon();
                        pm = db.PhieuMuons.First(x => x.MaPhieuMuon == phieumuon.MaPhieuMuon);
                        pm.MaDocGia = phieumuon.MaDocGia;
                        pm.MaCuonSach = phieumuon.MaCuonSach;
                        pm.NgayMuon = phieumuon.NgayMuon;
                        pm.NgayHetHan = phieumuon.NgayHetHan.AddDays(30);
                        db.SaveChanges();
                        MessageBox.Show("Đáo hạn thành công !", "Thông báo");
                        MaPhieuMuon = 0;
                        MaDocGia = 0;
                        MaCuonSach = 0;
                        NgayMuon = new DateTime(1994, 1, 1);
                        NgayHetHan = new DateTime(1994, 1, 1);
                        phieumuon = new PhieuMuon();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không phù hợp !", "Thông báo !");
            }
        }
    }
}
