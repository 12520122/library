using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("CT_PHIEUNHAPHANG")]

    public class CT_PhieuNhapSach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua chi tiet phieu nhap sach
        [Key]
        public int MaPNS { get; set; }
        [Key]
        public int MaSach { get; set; }
        //public DateTime NamXB { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public Sach Sach { get; set; }
        public PhieuNhapSach Phieunhapsahc { get; set; }

    }
}
