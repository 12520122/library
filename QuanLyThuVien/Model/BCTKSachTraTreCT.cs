using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("BCTKSACHTRATRECT")]
    public class BCTKSachTraTreCT
    {
        // tao bang cua bao cao chi tiet sach tra tre
        [Key, Column(Order = 1)]
        public int MaBCTKSachTraTre { get; set; } 
        [Key,Column(Order=2)]
        public int MaCuonSach { get; set; }
        // khoi tao khoa chinh cua bang

        public DateTime NgayMuon { get; set; }
        public int SoNgayTraTre { get; set; }
        public string GhiChu { get; set; }
       
        [ForeignKey("MaCuonSach")]
        [Column(Order=1)]
        public CuonSach CuonSach { get; set; }
        [ForeignKey("MaBCTKSachTraTre"), Column(Order = 2)]
        public BCTKSachTraTre BCTKSachTraTre { get; set; }
    }
}
