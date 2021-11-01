using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace QuanLyThuVien
{
    [Table("SACH")]

    public class Sach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
       // public int MaDauSach{ get; set; }
        //public ObservableCollection<DauSach> ListDauSach { get; set; }
        public int MaDauSach { get; set; }
        //khóa ngoại Mã Đầu Sách
        [ForeignKey("MaDauSach")]
        // khoa ngoai
        public virtual DauSach DauSach { get; set; }
    }
}
