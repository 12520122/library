using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("PHIEUNHAPSACH")]

    public class PhieuNhapSach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua phieu nhap sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaPNS { get; set; }
        
        public DateTime NgayLap { get; set; }
        //public int SoLuong { get; set; }
        public double TongTien{ get; set; }

    }
}
