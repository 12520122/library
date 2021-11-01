using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("TACGIA")]
    public class TacGia
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua tac gia
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        //public virtual ICollection<DauSach> DauSachs { get; set; }
        //[NotMapped]
        //public bool IsSelected { get; set; }
    }
}
