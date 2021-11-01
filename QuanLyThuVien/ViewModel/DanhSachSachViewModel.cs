using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.ComponentModel;

namespace QuanLyThuVien
{
    class DanhSachSachViewModel : ViewModelBase
    {

        // Tao list sach
        private ObservableCollection<CuonSach> listSach;

        //Ham  ListSach: truyen gia tri cho listCuonSach va lay gia tri tri cua listSach
        // Đối số truyền vào: Không có
        // Trả về kiểu List 
        public ObservableCollection<CuonSach> ListSach
        {
            get { return listSach; }
            set
            {
                listSach = value;
                OnPropertyChanged("ListSach");
            }
        }

        // Ten bien: dauSachCollection
        // Kieu du lieu: ICollectionView
        private ICollectionView dauSachCollection;

        //Ham  DauSachCollection: truyen gia tri cho listCuonSach va lay gia tri tri cua dauSachCollection
        // Đối số truyền vào: Không có
        // Trả về kiểu ICollectionView
        public ICollectionView DauSachCollection
        {
            get { return dauSachCollection; }
            set
            {
                dauSachCollection = value;
                OnPropertyChanged("DauSachCollection");
            }
        }

        // Ten bien: listSearch
        // Kieu du lieu: List<String>
        private List<string> listSearh;

        //Ham  ListSearch: truyen gia tri cho listCuonSach va lay gia tri tri cua listSearch
        // Đối số truyền vào: Không có
        // Trả về kiểu List<string>
        public List<string> ListSearch
        {
            get { return listSearh; }
            set
            {
                listSearh = value;

            }
        }

        // Ten bien: selectedSearch
        // kieu du lieu: string
        private string selectedSearch;

        //Ham  SelectedSearch: truyen gia tri cho listCuonSach va lay gia tri tri cua selectedSearch
        // Đối số truyền vào: Không có
        // Trả về kiểu: string
        public string SelectedSearch
        {
            get { return selectedSearch; }
            set { selectedSearch = value; }
        }
        //private DauSach selectedSach;
        //public DauSach SelectedSach
        //{
        //    get { return selectedSach; }
        //    set
        //    {
        //        selectedSach = value;
        //        OnPropertyChanged("SelectedSach");
        //    }
        //}
        //public LoaiSach LoaiSach
        //{
        //    get;
        //    set;
        //}

        // Ten bien: searchContent
        // Kieu du lieu: string
        private string searchContent;

        //Ham  SearchContent: truyen gia tri cho listCuonSach va lay gia tri tri cua searchContent
        // Đối số truyền vào: Không có
        // Trả về kiểu: string
        public string SearchContent
        {
            get { return searchContent; }
            set
            {
                searchContent = value;
                OnPropertyChanged("SearchContent");
                Update();
                FilterCollection();
            }
        }

        //Ham  DanhSachSachViewModel(): ham khoi tao cho class
        // Đối số truyền vào: Không có
        // Trả về kiểu: khong co
        public DanhSachSachViewModel()
        {
            InputListSearch();
            SelectedSearch = ListSearch.FirstOrDefault();
            using (var db = new QLTVContext())
            {
                //ListSach = new ObservableCollection<DauSach>(db.DauSachs.Include("LoaiSach").Include("CuonSachs").ToList());
                ListSach = new ObservableCollection<CuonSach>(db.CuonSachs.Include("DauSach.TacGias").Include("DauSach.LoaiSach").ToList());
            }
            Update();
        }

        //Ham  Filtering: Loc dieu kien can tim kiem khi ta chon mot thuoc tinh tim kiem
        // Đối số truyền vào: Không có
        // Trả về kiểu: bool
        private bool Filtering(object obj)
        {
            //DauSach data = obj as DauSach;
            CuonSach data = obj as CuonSach;
            if (data != null)
            {
                if (!string.IsNullOrEmpty(SearchContent))
                {
                    string content = SearchContent.ToString().ToUpper();
                    if (SelectedSearch.ToString() == "Tất cả")
                        return data.DauSach.TenDauSach.ToUpper().Contains(content) ||
                            data.DauSach.LoaiSach.TenLoaiSach.ToUpper().Contains(content) ||
                            data.MaCuonSach.ToString().ToUpper().Contains(content);
                    else if (SelectedSearch.ToString() == "Tên sách")
                        return data.DauSach.TenDauSach.ToUpper().Contains(content);
                    else if (SelectedSearch.ToString() == "Tên thể loại")
                        return data.DauSach.LoaiSach.TenLoaiSach.ToUpper().Contains(content);
                    else if (SelectedSearch.ToString() == "Mã sách")
                        return data.MaCuonSach.ToString().ToUpper().Contains(content);
                    else if (SelectedSearch.ToString() == "Tình trạng")
                        return false;
                }
                return true;
            }
            return false;
        }

        //Ham  Update: Cap nhat lai khi chon mot thuoc tinh tim kiem, dong thoi refresh du lieu cua DauSachCollection
        // Đối số truyền vào: Không có
        // Trả về kiểu: void
        private void Update()
        {
            DauSachCollection = CollectionViewSource.GetDefaultView(ListSach);
            DauSachCollection.Filter = new Predicate<object>(Filtering);
            DauSachCollection.Refresh();
        }

        //Ham  SearchContent:  Refresh du lieu trong DauSachCollection lai
        // Đối số truyền vào: Không có
        // Trả về kiểu: void
        private void FilterCollection()
        {
            if (DauSachCollection != null)
            {
                DauSachCollection.Refresh();
            }
        }

        //Ham  InputListSearch(): truyen cac thuoc tinh can tim kiem vao list de tim kiem
        // Đối số truyền vào: Không có
        // Trả về kiểu: void
        private void InputListSearch()
        {
            ListSearch = new List<string>();
            ListSearch.Add("Tất cả");
            ListSearch.Add("Mã sách");
            ListSearch.Add("Tên sách");
            ListSearch.Add("Tên thể loại");
            ListSearch.Add("Tình trạng");
        }
    }
}
