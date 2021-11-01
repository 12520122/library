namespace QuanLyThuVien.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyThuVien.QLTVContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(QuanLyThuVien.QLTVContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.LoaiDocGias.AddOrUpdate(
                x => x.TenLoaiDocGia,
                new LoaiDocGia { TenLoaiDocGia = "X" },
                new LoaiDocGia { TenLoaiDocGia = "Y" }
                );

            context.LoaiSachs.AddOrUpdate(
                x => x.TenLoaiSach,
                new LoaiSach { TenLoaiSach = "A" },
                new LoaiSach { TenLoaiSach = "B" },
                new LoaiSach { TenLoaiSach = "C" }
                );
            context.ThamSos.AddOrUpdate(
                x => x.TenThamSo,
                new ThamSo { TenThamSo = "TuoiDocGiaToiThieu", GiaTri = 18 },
                new ThamSo { TenThamSo = "TuoiDocGiaToiDa", GiaTri = 55 },
                new ThamSo { TenThamSo = "SoThangThoiHanThe", GiaTri = 6 },
                new ThamSo { TenThamSo = "SoNamThoiHanXuatBan", GiaTri = 8 },
                new ThamSo { TenThamSo = "SoSachMuonToiDa", GiaTri = 5 },
                new ThamSo { TenThamSo = "SoNgayMuonToiDa", GiaTri = 1 },
                new ThamSo { TenThamSo = "TienPhat", GiaTri = 1000 },
                new ThamSo { TenThamSo = "ApDungQDTienThu", GiaTri = 1 }
                );
        }
    }
}
