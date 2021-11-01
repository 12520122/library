using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("PHIEUTHUTIEN")]

    public class PhieuThuTien
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua phieu thu tien
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaPhieuThu { get; set; }
        public DateTime NgayThu { get; set; }
        public int SoTien { get; set; }
        public int ConLai { get; set; }
        public int MaDocGia { get; set; }

        [ForeignKey("MaDocGia")]
        // khoa ngoai
        public virtual DocGia DocGia { get; set; }
    }
}
