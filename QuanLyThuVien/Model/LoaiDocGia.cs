using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("LOAIDOCGIA")]
    public class LoaiDocGia
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua loai doc gia
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaLoaiDocGia { get; set; }
        public string TenLoaiDocGia { get; set; }
    }
}
