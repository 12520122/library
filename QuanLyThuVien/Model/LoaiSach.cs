using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("LOAISACH")]
    public class LoaiSach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua loai sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
        public virtual ICollection<DauSach> DauSachs { get; set; }
    }
}
