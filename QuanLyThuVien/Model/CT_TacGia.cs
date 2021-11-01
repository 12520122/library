using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("CT_TACGIA")]  

    public class CT_TacGia
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua chi tiet tac gia
        [Key]
        public int MaTacGia { get; set; }
        [Key]
        public int MaLoaiSach { get; set; }
        
    }
}
