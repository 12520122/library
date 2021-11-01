using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace QuanLyThuVien
{
    class PhieuThuTienViewModel : ViewModelBase, IDataErrorInfo
    {
        #region IDataErrorInfo Members

        // Ham Error: tra ve loi cua he thong
        // Doi so truyen vao: khong co
        // Kieu tra ve: string
        public string Error
        {
            get { throw new NotImplementedException(); }
        }


        // Ham Error: tra ve loi cua he thong
        // Doi so truyen vao: columnName
        // Kieu tra ve: string
        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "SoTien":
                        if (SoTien <= 0)
                        {
                            result = "Vui lòng nhập số tiền!!!";
                        }
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
        #endregion

        // Tao mot listDocGia
        private ObservableCollection<DocGia> listDocGia;

        // Ham ListDocGia: truyen gia tri va lay gia tri cua listDocGia
        // Doi so truyen vao: khong co
        // Kieu tra ve: ObservableCollection<DocGia> 
        public ObservableCollection<DocGia> ListDocGia
        {
            get { return listDocGia; }
            set
            {
                if (listDocGia != value)
                {
                    listDocGia = value;
                    OnPropertyChanged("ListDocGia");
                }
            }
        }

        // Ten bien: ngayThu
        // Kieu du lieu: DateTime
        private DateTime ngayThu;

        // Ham  NgayThu: truyen gia tri va lay gia tri cua bien ngayThu
        // Doi so truyen vao: khong co
        // Kieu tra ve: DateTime
        public DateTime NgayThu
        {
            get { return ngayThu; }
            set { ngayThu = value; }
        }

        // Ten bien: soTien
        // Kieu du lieu: int
        private int soTien;

        // Ham SoTien: truyen gia tri va lay gia tri cua bien soTien
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int SoTien
        {
            get { return soTien; }
            set
            {
                if (soTien != value)
                {
                    soTien = value;
                    OnPropertyChanged("SoTien");
                    ConLai = selectedDocGia.TongNo - soTien;
                }
            }
        }

        // Ten bien: con lai
        // Kieu du lieu: int
        private int conLai;

        // Ham ConLai : truyen gia tri va lay gia tri cua bien conLai
        // Doi so truyen vao: khong co
        // Kieu tra ve: int
        public int ConLai
        {
            get { return conLai; }
            set
            {
                if (conLai != value)
                {
                    conLai = value;
                    OnPropertyChanged("ConLai");
                }
            }
        }

        // Ten bien: SelectedDocGia
        // Kieu du lieu: DocGia
        private DocGia selectedDocGia;

        // Ham SelectedDocGia : truyen gia tri va lay gia tri cua selectedDocGia
        // Doi so truyen vao: khong co
        // Kieu tra ve: Docgia
        public DocGia SelectedDocGia
        {
            get { return selectedDocGia; }
            set
            {
                selectedDocGia = value;
                OnPropertyChanged("SelectedDocGia");
            }
        }

        //Ten bien: isEnable
        // Kieu du lieu: bool
        private bool isEnable;

        // Ham IsEnable: truyen gia tri va lay gia tri cua isEnable
        // Doi so truyen vao: khong co
        // Kieu tra ve: bool
        public bool IsEnable
        {
            get { return isEnable; }
            set
            {
                if (isEnable != value)
                {
                    isEnable = value;
                    OnPropertyChanged("IsEnable");
                }
            }
        }

        // Ten bien: saveCommand
        // Kieu du lieu: ICommand
        private ICommand saveCommand;

        // Ham SaveCommand: truyen gia tri va lay gia tri cua saveCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve: ICommad
        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }

        // Ten bien: addNewCommand
        // kieu du lieu ICommand
        private ICommand addNewCommand;

        // Ham AddNewCommand: truyen gia tri va lay gia tri cua  addNewCommand
        // Doi so truyen vao: khong co
        // Kieu tra ve:
        public ICommand AddNewCommand
        {
            get { return addNewCommand; }
            set { addNewCommand = value; }
        }

        // Ham : 
        // Doi so truyen vao: khong co
        // Kieu tra ve:
        public PhieuThuTienViewModel()
        {
            NgayThu = DateTime.Now.Date;
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
            AddNewCommand = new RelayCommand(new Action<object>(AddNew));
            using (var db = new QLTVContext())
            {
                ListDocGia = new ObservableCollection<DocGia>(db.DocGias.ToList());
                SelectedDocGia = db.DocGias.FirstOrDefault();
            }
            ConLai = SelectedDocGia.TongNo - SoTien;
            IsEnable = false;
        }

        // Ham ShowMessage: ham show cac thong bao
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        public void ShowMessage(object obj)
        {
            if (SoTien == 0)
            {
                MessageBox.Show("Số tiền thu không hợp lệ");
                return;
            }
            using (var db = new QLTVContext())
            {
                int ApDungQDTienThu = db.ThamSos.First(x => x.TenThamSo == "ApDungQDTienThu").GiaTri;
                if (ApDungQDTienThu == 1)
                {
                    if (ConLai < 0)
                    {
                        MessageBox.Show("Số tiền thu không vượt quá số tiền độc giả đang nợ");
                        return;
                    }
                }
                PhieuThuTien phieuthutien = new PhieuThuTien();
                phieuthutien.NgayThu = NgayThu;
                phieuthutien.SoTien = SoTien;
                ConLai = SelectedDocGia.TongNo - SoTien;
                phieuthutien.ConLai = ConLai;
                phieuthutien.MaDocGia = SelectedDocGia.MaDocGia;
                db.PhieuThuTiens.Add(phieuthutien);
                //db.SaveChanges();
                DocGia docgia = new DocGia();
                docgia = db.DocGias.FirstOrDefault(x => x.MaDocGia == SelectedDocGia.MaDocGia);
                if (docgia != null)
                {
                    //docgia.HoTen = SelectedDocGia.HoTen;
                    //docgia.MaLoaiDocGia = SelectedDocGia.MaLoaiDocGia;
                    //docgia.NgaySinh = SelectedDocGia.NgaySinh;
                    //docgia.NgayLapThe = SelectedDocGia.NgayLapThe;
                    //docgia.NgayHetHan = SelectedDocGia.NgayHetHan;
                    //docgia.DiaChi = SelectedDocGia.DiaChi;
                    //docgia.Email = SelectedDocGia.Email;
                    docgia.TongNo = phieuthutien.ConLai;
                }
                db.SaveChanges();
            }
            IsEnable = false;
            MessageBox.Show("Thành công!!!");
            var e = Application.Current.Windows.GetEnumerator();
            while (e.MoveNext())
            {
                Window value = e.Current as Window;
                if (value.Title == "PHIẾU THU TIỀN PHẠT")
                    value.Close();
            }
        }

        // Ham AddNew: Xoa du lieu khi muon nhap du lieu moi
        // Doi so truyen vao: obj(object)
        // Kieu tra ve: void
        private void AddNew(object obj)
        {
            IsEnable = true;
        }
    }
}
