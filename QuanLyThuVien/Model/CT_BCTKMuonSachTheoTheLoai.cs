using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("CT_BCTKMUONSACHTHEOTHELOAI")]

    public class CT_BCTKMuonSachTheTheLoai
    {
        // khoi tao cac gia tri cua bang chi tiet bao cao muon sach theo the loai
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khai bao khoa chinh cua bang
        // cac thuoc tinh trong bang 
        public int MaCT_BCTKMuonSachTheTheLoai { get; set; }
        public int MaLoaiSach { get; set; }
        [ForeignKey("MaLoaiSach")]
        // khai bao khoa ngoai
        public virtual LoaiSach LoaiSach { get; set; }
        public int SoLuot { get; set; }
        public double TiLe { get; set; }
        public int MaBCTKMS { get; set; }
        [ForeignKey("MaBCTKMS")]
        // khai bao khoa ngoai
        
        public virtual BCTKMuonSachTheoTheLoai BCTKMuonTheoTheLoai { get; set; }
        
    }
}
