
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class QLTVContext : DbContext
    {
        public QLTVContext()
            : base(KetNoiDbViewModel.Cnn)
        { }
        //public QLTVContext()
        //    : base("QuanLyThuVien_QLTVContext")
        //{ }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<LoaiDocGia> LoaiDocGias { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        //public DbSet<Sach> Sachs { get; set; }
        public DbSet<DauSach> DauSachs { get; set; }
        public DbSet<CuonSach> CuonSachs { get; set; }
        public DbSet<LoaiSach> LoaiSachs { get; set; }
        public DbSet<ThamSo> ThamSos { get; set; }
        public DbSet<PhieuNhapSach> PhieuNhapSachs { get; set; }
        public DbSet<PhieuThuTien> PhieuThuTiens { get; set; }
        public DbSet<BCTKMuonSachTheoTheLoai> BCTheLoais { get; set; }
        public DbSet<CT_BCTKMuonSachTheTheLoai> CT_BCMTheLoais { get; set; }
        public DbSet<PhieuTra> PhieuTras { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get;set;}

        public DbSet<QuyenHan> QuyenHans { get; set; }
        public DbSet<BCTKSachTraTre> BCTraTres { get; set; }

        //public DbSet<CT_BCTKMuonSachTheTheLoai> CT_BCTKMuonSachTheTheLoais { get; set; }
        //public DbSet<BCTKSachTraTreCT> BCTraTreCTs { get; set; }
      
        

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PhieuMuon>().
        //      HasMany(c => c.CuonSachs).
        //      WithMany().
        //      Map(
        //       m =>
        //       {
        //           m.MapLeftKey("MaPhieuMuon");
        //           m.MapRightKey("MaCuonSach");
        //           m.ToTable("PhieuMuon_CuonSach");
        //       });
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DauSach>().
              HasMany(c => c.TacGias).
              WithMany().
              Map(
               m =>
               {
                   m.MapLeftKey("MaDauSach");
                   m.MapRightKey("MaTacGia");
                   m.ToTable("DAUSACH_TACGIA");
               });
        }
       
    }
}
