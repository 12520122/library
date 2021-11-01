using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("PHIEUMUON")]

    public class PhieuMuon
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua phieu muon sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        
        public int MaDocGia { get; set; }
        [ForeignKey("MaDocGia")]
        // khoa phu
        //[Column(Order = 1)]
        public DocGia DocGia { get; set; }

        public int MaCuonSach { get; set; }

        [ForeignKey("MaCuonSach")]
        // khoa phu
        public virtual CuonSach CuonSach { get; set; }

        public bool DaTra { get; set; }

        public DateTime NgayHetHan { get; set; }
        //public ICollection<CuonSach> CuonSachs { get; set; }
    }
}
