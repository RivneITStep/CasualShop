﻿// <auto-generated />
using System;
using CasualShop.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CasualShop.DAL.Migrations
{
    [DbContext(typeof(EFDBContext))]
    [Migration("20200912080800_updated images")]
    partial class updatedimages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CasualShop.DAL.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketClothesId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("CurrentUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isProcessed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Baskets_tbl");
                });

            modelBuilder.Entity("CasualShop.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands_tbl");
                });

            modelBuilder.Entity("CasualShop.DAL.Entities.Clothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothesBrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClothesBrandId");

                    b.HasIndex("ImageId");

                    b.HasIndex("TagId");

                    b.ToTable("Clothes_tbl");
                });

            modelBuilder.Entity("CasualShop.DAL.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Images_tbl");
                });

            modelBuilder.Entity("CasualShop.DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags_tbl");
                });

            modelBuilder.Entity("CasualShop.DAL.Entities.Clothes", b =>
                {
                    b.HasOne("CasualShop.DAL.Entities.Brand", "ClothesBrand")
                        .WithMany()
                        .HasForeignKey("ClothesBrandId");

                    b.HasOne("CasualShop.DAL.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("CasualShop.DAL.Entities.Tag", "Tag")
                        .WithMany("Clothes")
                        .HasForeignKey("TagId");
                });
#pragma warning restore 612, 618
        }
    }
}