using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien
{
    [Table("QUYENHAN")]
    public class QuyenHan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public string DiaChi { get; set; }
        public string chucvu { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

    }
}
