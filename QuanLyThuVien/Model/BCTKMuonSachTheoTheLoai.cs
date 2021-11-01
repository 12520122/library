using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("BCTKMUONSACHTHEOTHELOAI")]

    public class BCTKMuonSachTheoTheLoai
    {
        // Khoi tao cac thanh phan trong bang bao cao thong ke muon sach theo the loai

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Tao khao chinh cho bang cua MaBCTKMS
        public int MaBCTKMS { get; set; }
       // public DateTime NgayLap { get; set; }
        //[Key]
        //[Column(Order=2)]
        public int Thang { get; set; }
       // [Key]
        //[Column(Order = 1)]
        public int Nam { get; set; }
        public int TongSo { get; set; }
       // public int MaTheLoai{get;set;}
        // Cac thanh phan cua bang

        public virtual ICollection<CT_BCTKMuonSachTheTheLoai> CT_BCTKMuonSachTheTheLoais { get; set; }
        // tao bien chi tiet bao cao thong ke muon sach theo the loai
        public BCTKMuonSachTheoTheLoai()
        {
            CT_BCTKMuonSachTheTheLoais = new List<CT_BCTKMuonSachTheTheLoai>();
        }
    }
}
