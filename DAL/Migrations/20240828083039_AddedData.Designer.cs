﻿// <auto-generated />
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ComputerStoreContext))]
    [Migration("20240828083039_AddedData")]
    partial class AddedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Anakart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("Anakartlar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Asus",
                            KdvRate = 18m,
                            Model = "ROG Strix B550-F",
                            Quantity = 10,
                            UnitPrice = 2000m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "MSI",
                            KdvRate = 18m,
                            Model = "MAG B550 TOMAHAWK",
                            Quantity = 15,
                            UnitPrice = 1850.75m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Computer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnakartId")
                        .HasColumnType("int");

                    b.Property<int>("EkranKartiId")
                        .HasColumnType("int");

                    b.Property<int>("IslemciId")
                        .HasColumnType("int");

                    b.Property<int>("KlavyeId")
                        .HasColumnType("int");

                    b.Property<int>("MonitorId")
                        .HasColumnType("int");

                    b.Property<int>("MouseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RamId")
                        .HasColumnType("int");

                    b.Property<int>("SSDId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AnakartId");

                    b.HasIndex("EkranKartiId");

                    b.HasIndex("IslemciId");

                    b.HasIndex("KlavyeId");

                    b.HasIndex("MonitorId");

                    b.HasIndex("MouseId");

                    b.HasIndex("RamId");

                    b.HasIndex("SSDId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("DAL.Entities.ComputerMonitor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("ComputerMonitors");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Dell",
                            KdvRate = 10m,
                            Model = "UltraSharp U2720Q",
                            Quantity = 8,
                            Size = 27,
                            UnitPrice = 4500.99m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "Samsung",
                            KdvRate = 10m,
                            Model = "Odyssey G7",
                            Quantity = 5,
                            Size = 32,
                            UnitPrice = 5500.75m
                        });
                });

            modelBuilder.Entity("DAL.Entities.EkranKarti", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("MemorySize")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("EkranKartlari");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "NVIDIA",
                            KdvRate = 18m,
                            MemorySize = 0,
                            Model = "GeForce RTX 3080",
                            Quantity = 7,
                            UnitPrice = 12000.00m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "AMD",
                            KdvRate = 18m,
                            MemorySize = 16,
                            Model = "Radeon RX 6800 XT",
                            Quantity = 5,
                            UnitPrice = 11000.50m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Islemci", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("ClockSpeed")
                        .HasColumnType("float");

                    b.Property<int>("CoreCount")
                        .HasColumnType("int");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("Islemciler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Intel",
                            ClockSpeed = 3.5,
                            CoreCount = 8,
                            KdvRate = 18m,
                            Model = "Core i9-11900K",
                            Quantity = 12,
                            UnitPrice = 7000m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "AMD",
                            ClockSpeed = 3.3999999999999999,
                            CoreCount = 16,
                            KdvRate = 10m,
                            Model = "Ryzen 9 5950X",
                            Quantity = 10,
                            UnitPrice = 8500.50m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Klavye", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsWireless")
                        .HasColumnType("bit");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("Klavyeler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Logitech",
                            IsWireless = false,
                            KdvRate = 0m,
                            Model = "G Pro X",
                            Quantity = 20,
                            UnitPrice = 1200.50m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "Razer",
                            IsWireless = true,
                            KdvRate = 18m,
                            Model = "BlackWidow V3 Pro",
                            Quantity = 15,
                            UnitPrice = 1500.75m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Mouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsSilentTouch")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWireless")
                        .HasColumnType("bit");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("Mice");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Logitech",
                            IsSilentTouch = false,
                            IsWireless = false,
                            KdvRate = 18m,
                            Model = "G502 HERO",
                            Quantity = 25,
                            UnitPrice = 450.99m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "Razer",
                            IsSilentTouch = true,
                            IsWireless = true,
                            KdvRate = 18m,
                            Model = "DeathAdder V2 Pro",
                            Quantity = 18,
                            UnitPrice = 750.50m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Ram", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("Rams");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Corsair",
                            Capacity = 16,
                            KdvRate = 18m,
                            Model = "Vengeance LPX",
                            Quantity = 30,
                            UnitPrice = 1200m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "G.Skill",
                            Capacity = 32,
                            KdvRate = 10m,
                            Model = "Trident Z RGB",
                            Quantity = 20,
                            UnitPrice = 1500.50m
                        });
                });

            modelBuilder.Entity("DAL.Entities.SSD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("KdvRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("ID");

                    b.ToTable("SSDs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Brand = "Samsung",
                            Capacity = 1000,
                            KdvRate = 18m,
                            Model = "970 EVO Plus",
                            Quantity = 15,
                            UnitPrice = 2000m
                        },
                        new
                        {
                            ID = 2,
                            Brand = "Western Digital",
                            Capacity = 2000,
                            KdvRate = 10m,
                            Model = "WD Black SN850",
                            Quantity = 10,
                            UnitPrice = 2500.75m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Computer", b =>
                {
                    b.HasOne("DAL.Entities.Anakart", "Anakart")
                        .WithMany("Computers")
                        .HasForeignKey("AnakartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.EkranKarti", "EkranKarti")
                        .WithMany("Computers")
                        .HasForeignKey("EkranKartiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Islemci", "Islemci")
                        .WithMany("Computers")
                        .HasForeignKey("IslemciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Klavye", "Klavye")
                        .WithMany("Computers")
                        .HasForeignKey("KlavyeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.ComputerMonitor", "ComputerMonitor")
                        .WithMany("Computers")
                        .HasForeignKey("MonitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Mouse", "Mouse")
                        .WithMany("Computers")
                        .HasForeignKey("MouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Ram", "Ram")
                        .WithMany("Computers")
                        .HasForeignKey("RamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.SSD", "SSD")
                        .WithMany("Computers")
                        .HasForeignKey("SSDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anakart");

                    b.Navigation("ComputerMonitor");

                    b.Navigation("EkranKarti");

                    b.Navigation("Islemci");

                    b.Navigation("Klavye");

                    b.Navigation("Mouse");

                    b.Navigation("Ram");

                    b.Navigation("SSD");
                });

            modelBuilder.Entity("DAL.Entities.Anakart", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.ComputerMonitor", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.EkranKarti", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.Islemci", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.Klavye", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.Mouse", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.Ram", b =>
                {
                    b.Navigation("Computers");
                });

            modelBuilder.Entity("DAL.Entities.SSD", b =>
                {
                    b.Navigation("Computers");
                });
#pragma warning restore 612, 618
        }
    }
}
