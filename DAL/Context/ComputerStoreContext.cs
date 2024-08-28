using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ComputerStoreContext:DbContext
    {
        //connectionString 
        //Farklı veritabanı bağlantıları için FactoryPattern kullanılabilir
        private readonly string connectionString = "server=localhost;database=ComputerStoreDB;Trusted_Connection=true;TrustServerCertificate=true";

        //Tablo
        DbSet<Computer> Computers {  get; set; }
        DbSet<Anakart> Anakartlar {  get; set; } 
        DbSet<EkranKarti> EkranKartlari { get; set; }
        DbSet<Islemci> Islemciler { get; set; }
        DbSet<Klavye> Klavyeler {  get; set; }
        DbSet<ComputerMonitor> ComputerMonitors { get; set; }
        DbSet<Mouse> Mice {  get; set; }
        DbSet<Ram> Rams { get; set; }
        DbSet<SSD> SSDs { get; set; }

        //OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Computer
            modelBuilder.Entity<Computer>().Property(x => x.Name).HasMaxLength(50);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Anakart)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.AnakartId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.ComputerMonitor)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.MonitorId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.EkranKarti)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.EkranKartiId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Islemci)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.IslemciId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Klavye)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.KlavyeId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Mouse)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.MouseId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Ram)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.RamId);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.SSD)
                .WithMany(x => x.Computers)
                .HasForeignKey(x => x.SSDId);

            //Anakart
            modelBuilder.Entity<Anakart>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Anakart>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Anakart>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<Anakart>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<Anakart>().HasData(AnakartData.Anakartlar);

            //ComputerMonitor
            modelBuilder.Entity<ComputerMonitor>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<ComputerMonitor>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<ComputerMonitor>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<ComputerMonitor>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<ComputerMonitor>().HasData(ComputerMonitorData.ComputerMonitors);

            //EkranKarti
            modelBuilder.Entity<EkranKarti>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<EkranKarti>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<EkranKarti>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<EkranKarti>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<EkranKarti>().HasData(EkranKartiData.EkranKartlari);

            //Islemci
            modelBuilder.Entity<Islemci>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Islemci>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Islemci>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<Islemci>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<Islemci>().HasData(IslemciData.Islemciler);

            //Klavye
            modelBuilder.Entity<Klavye>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Klavye>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Klavye>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<Klavye>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<Klavye>().HasData(KlavyeData.Klavyeler);

            //Mouse
            modelBuilder.Entity<Mouse>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Mouse>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Mouse>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<Mouse>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<Mouse>().HasData(MouseData.Mice);

            //Ram
            modelBuilder.Entity<Ram>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Ram>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Ram>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<Ram>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<Ram>().HasData(RamData.Rams);

            //SSD
            modelBuilder.Entity<SSD>().Property(x => x.UnitPrice).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<SSD>().Property(x => x.KdvRate).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<SSD>().Property(x => x.Brand).HasMaxLength(50);
            modelBuilder.Entity<SSD>().Property(x => x.Model).HasMaxLength(50);
            //Data
            modelBuilder.Entity<SSD>().HasData(SSDData.SSDs);

            base.OnModelCreating(modelBuilder);
        }
    }
}
