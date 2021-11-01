using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    [Table("THAMSO")]

    public class ThamSo
    {
        //public int STT { get; set; }
        //public int TuoiToiThieu { get; set; }
        //public int TuoiToiDa { get; set; }
        //public int ThoiHanThe { get; set; }
        //public DateTime Thang { get; set; }
        //public DateTime ThoiHanXuatBan { get; set; }
        //public int SoSachMuonToiDa { get; set; }
        //public int SoNgayMuonToiDa { get; set; }
        //public double TienPhat { get; set; }
        //public bool ApDungQDTienThu { get; set; }

        // bang tao cac thuoc tinh va khoa chinh va phu cua tham so
        [Key]
        public string TenThamSo { get; set; }
        public int GiaTri { get; set; }


    }
}
