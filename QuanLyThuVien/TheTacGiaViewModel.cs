using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyThuVien
{
    class TheTacGiaViewModel: ViewModelBase
    {
         private String tenTacGia;
        public String TenTacGia
        {
            get { return tenTacGia; }
            set
            {
                if (tenTacGia != value)
                {
                    tenTacGia = value;
                    OnPropertyChanged("TenTacGia");
                }
            }
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }
            public TheTacGiaViewModel()
        {
            TenTacGia="Nguyen A";
            SaveCommand = new RelayCommand(new Action<object>(ShowMessage));
        }
        public void ShowMessage(object obj)
        {
            MessageBox.Show(TenTacGia);
            using (var db = new QLTVContext())
            {
                TacGia tacgia = new TacGia();
                tacgia.TenTacGia = TenTacGia;
                db.TacGias.Add(tacgia);
                db.SaveChanges();
            }
        }
    }
}
