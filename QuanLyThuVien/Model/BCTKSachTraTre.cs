using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("BCTKSACHTRATRE")]

    public class BCTKSachTraTre
    {
        // Tao bang cua chi tiet sach tra tre
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh 
        public int MaBCTKSachTraTre { get; set; }
        //public DateTime NgayLap { get; set; }
        //[Key]
        //[Column(Order=1)]
        public DateTime NgayBaoCao { get; set; }
        //[Key]
        //[Column(Order=2)]
        public int MaCuonSach { get; set; }
        [ForeignKey("MaCuonSach")]
        // khao ngoai
        public CuonSach CuonSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public int SoNgayTraTre { get; set; }
        //public 
    }
}
