﻿// <auto-generated />
using CodeFristApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFristApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602131329_MakeRelashinShip")]
    partial class MakeRelashinShip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFristApp.Models.BranchModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Branch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Addres = "Riyadh",
                            Area = "------",
                            Name = "branch01"
                        },
                        new
                        {
                            Id = 2,
                            Addres = "Jeddah",
                            Area = "------",
                            Name = "branch02"
                        },
                        new
                        {
                            Id = 3,
                            Addres = "Qassim",
                            Area = "------",
                            Name = "branch03"
                        },
                        new
                        {
                            Id = 4,
                            Addres = "Riyadh",
                            Area = "------",
                            Name = "branch04"
                        });
                });

            modelBuilder.Entity("CodeFristApp.Models.CostomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FristName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Costomers");
                });

            modelBuilder.Entity("CodeFristApp.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFristApp.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("CostomerId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CostomerId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("CodeFristApp.Models.ProfileModel", b =>
                {
                    b.HasOne("CodeFristApp.Models.CostomerModel", "Costomer")
                        .WithOne("Profile")
                        .HasForeignKey("CodeFristApp.Models.ProfileModel", "CostomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
