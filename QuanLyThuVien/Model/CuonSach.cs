using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("CUONSACH")]

    public class CuonSach
    {
        // bang tao cac thuoc tinh va khoa chinh va phu cua cuon sach
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // khoa chinh
        public int MaCuonSach { get; set; }
        public bool TinhTrangSach { get; set; }


        public int MaDauSach { get; set; }
        [ForeignKey("MaDauSach")]
        // khoa phu
        public virtual DauSach DauSach { get; set; }
       
    }
}
