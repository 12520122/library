using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("PHIEUTRA")]

    public class PhieuTra
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua phieu tra sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaPhieuTra { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNgayMuon { get; set; }
        public int SoNgayTraTre { get; set; }
        public int TienPhat { get; set; }
        public int MaPhieuMuon { get; set; }
        [ForeignKey("MaPhieuMuon")]
        // khoa ngoai
        public PhieuMuon PhieuMuon { get; set; }
    }
}
