using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("DOCGIA")]
    public class DocGia
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua doc gia
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int TongNo { get; set; }
        public int MaLoaiDocGia { get; set; }

        [ForeignKey("MaLoaiDocGia")]
        // khoa phu
        public virtual LoaiDocGia LoaiDocGia { get; set; }
    }
}
