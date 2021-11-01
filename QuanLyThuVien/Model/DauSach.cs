using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("DAUSACH")]

    public class DauSach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua dau sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        
        //public LoaiSach Loaisach { get; set; }
        //public TacGia Tacgia { get; set; }
        public string NhaXB { get; set; }
        public int NamXB { get; set; }
        public int TriGia { get; set; }

        public int MaLoaiSach { get; set; }
        [ForeignKey("MaLoaiSach")]
        // khoa phu
        //[Column(Order = 1)]
        public LoaiSach LoaiSach { get; set; }
        //public int MaTacGia { get; set; }

        //[ForeignKey("MaTacGia")]
        //[Column(Order = 2)]
        //public TacGia TacGia { get; set; }
        
        public virtual ICollection<CuonSach> CuonSachs { get; set; }
        public virtual ICollection<TacGia> TacGias { get; set; }
        public DauSach()
        {
            TacGias = new List<TacGia>();
            // tao 1 list tac gia
        }
    }
}
