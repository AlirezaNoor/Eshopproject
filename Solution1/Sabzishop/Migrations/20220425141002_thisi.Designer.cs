﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sabzishop.Db_Context;

namespace Sabzishop.Migrations
{
    [DbContext(typeof(MyDb))]
    [Migration("20220425141002_thisi")]
    partial class thisi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sabzishop.Models.Category.Category", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            name = "گوشی"
                        },
                        new
                        {
                            id = 2L,
                            name = "لپ تاپ"
                        },
                        new
                        {
                            id = 3L,
                            name = "تبلت"
                        },
                        new
                        {
                            id = 4L,
                            name = "هدفون و هدست"
                        },
                        new
                        {
                            id = 5L,
                            name = "کنسول بازی"
                        });
                });

            modelBuilder.Entity("Sabzishop.Models.Discount.Descount", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("enddes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("now")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("pricedes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("proid")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("proid")
                        .IsUnique();

                    b.ToTable("Descount");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            enddes = new DateTime(2022, 5, 2, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 4, 25, 18, 40, 1, 246, DateTimeKind.Local).AddTicks(8696),
                            pricedes = 590000m,
                            proid = 4L
                        },
                        new
                        {
                            id = 2L,
                            enddes = new DateTime(2022, 5, 1, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5303),
                            pricedes = 490000m,
                            proid = 7L
                        },
                        new
                        {
                            id = 3L,
                            enddes = new DateTime(2022, 5, 3, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5390),
                            pricedes = 390000m,
                            proid = 8L
                        },
                        new
                        {
                            id = 4L,
                            enddes = new DateTime(2022, 5, 4, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5401),
                            pricedes = 490000m,
                            proid = 10L
                        },
                        new
                        {
                            id = 5L,
                            enddes = new DateTime(2022, 5, 2, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 4, 25, 18, 40, 1, 251, DateTimeKind.Local).AddTicks(5408),
                            pricedes = 990000m,
                            proid = 11L
                        });
                });

            modelBuilder.Entity("Sabzishop.Models.Products.Products", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ISspesial")
                        .HasColumnType("bit");

                    b.Property<long>("categoryid")
                        .HasColumnType("bigint");

                    b.Property<long>("descountid")
                        .HasColumnType("bigint");

                    b.Property<string>("discriptio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("instroe")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("categoryid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            ISspesial = true,
                            categoryid = 1L,
                            descountid = 0L,
                            discriptio = "یک گوشی مناسب وارزان",
                            instroe = 4L,
                            name = "گوشی موبایل Xiaomi Mi 9",
                            price = 350000m
                        },
                        new
                        {
                            id = 2L,
                            ISspesial = false,
                            categoryid = 4L,
                            descountid = 0L,
                            discriptio = "یک هنسفری مناسب ",
                            instroe = 3L,
                            name = "هندزفری بی سیم Sony",
                            price = 3800m
                        },
                        new
                        {
                            id = 3L,
                            ISspesial = false,
                            categoryid = 5L,
                            descountid = 0L,
                            discriptio = "عرصه بازی های اولیه در ایران ",
                            instroe = 3L,
                            name = "دسته بازی PS4",
                            price = 3800m
                        },
                        new
                        {
                            id = 4L,
                            ISspesial = true,
                            categoryid = 4L,
                            descountid = 1L,
                            discriptio = "هندزفری بلوتوثی بی سیم Xiaomi iBfree ",
                            instroe = 15L,
                            name = "هندزفری بلوتوثی بی سیم Xiaomi iBfree",
                            price = 790000m
                        },
                        new
                        {
                            id = 13L,
                            ISspesial = true,
                            categoryid = 2L,
                            descountid = 0L,
                            discriptio = "هدفون حرفه ای گیمینگ Beats ",
                            instroe = 15L,
                            name = "هدفون حرفه ای گیمینگ Beats",
                            price = 790000m
                        },
                        new
                        {
                            id = 5L,
                            ISspesial = true,
                            categoryid = 1L,
                            descountid = 0L,
                            discriptio = "گوشی آیفون  ",
                            instroe = 10L,
                            name = "گوشی آیفون",
                            price = 350000m
                        },
                        new
                        {
                            id = 6L,
                            ISspesial = false,
                            categoryid = 1L,
                            descountid = 0L,
                            discriptio = "گوشی شیاموی رد می",
                            instroe = 15L,
                            name = "گوشی شیاموی رد می",
                            price = 350000m
                        },
                        new
                        {
                            id = 7L,
                            ISspesial = true,
                            categoryid = 2L,
                            descountid = 2L,
                            discriptio = "هدفون حرفه ای گیمینگ Beats ",
                            instroe = 15L,
                            name = "هدفون حرفه ای گیمینگ Beats",
                            price = 790000m
                        },
                        new
                        {
                            id = 8L,
                            ISspesial = false,
                            categoryid = 5L,
                            descountid = 3L,
                            discriptio = "کنسول زیبا برای شما",
                            instroe = 15L,
                            name = "کنسول pes4",
                            price = 790000m
                        },
                        new
                        {
                            id = 9L,
                            ISspesial = false,
                            categoryid = 4L,
                            descountid = 0L,
                            discriptio = "اسپیکر بلوتوثی قابل حمل Anker",
                            instroe = 15L,
                            name = "اسپیکر بلوتوثی قابل حمل Anker",
                            price = 200000m
                        },
                        new
                        {
                            id = 10L,
                            ISspesial = true,
                            categoryid = 2L,
                            descountid = 4L,
                            discriptio = "لپ اپ های زیبا روی ایران",
                            instroe = 15L,
                            name = "لپ تاپ شیامی",
                            price = 1200000m
                        },
                        new
                        {
                            id = 11L,
                            ISspesial = false,
                            categoryid = 3L,
                            descountid = 5L,
                            discriptio = "تبلت های های زیبا",
                            instroe = 15L,
                            name = "تبلت های زیبا ",
                            price = 1200000m
                        },
                        new
                        {
                            id = 12L,
                            ISspesial = true,
                            categoryid = 3L,
                            descountid = 0L,
                            discriptio = "تبلت های های زیبا",
                            instroe = 15L,
                            name = "تبلت های آسوز",
                            price = 1200000m
                        });
                });

            modelBuilder.Entity("Sabzishop.Models.Slider.Slider", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("undertitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("slider");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون1",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 2L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون2",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 3L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون3",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 4L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "4تله فیزیون",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 5L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون5",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 6L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون6",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 7L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون7",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 8L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "تله فیزیون8",
                            undertitle = "شپولی جونم"
                        },
                        new
                        {
                            id = 9L,
                            discription = "این یه نمونه برای شما که هستی ",
                            title = "9 فیزیون",
                            undertitle = "شپولی جونم"
                        });
                });

            modelBuilder.Entity("Sabzishop.Models.Discount.Descount", b =>
                {
                    b.HasOne("Sabzishop.Models.Products.Products", "Products")
                        .WithOne("descount")
                        .HasForeignKey("Sabzishop.Models.Discount.Descount", "proid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Sabzishop.Models.Products.Products", b =>
                {
                    b.HasOne("Sabzishop.Models.Category.Category", "Category")
                        .WithMany("ProductsList")
                        .HasForeignKey("categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Sabzishop.Models.Category.Category", b =>
                {
                    b.Navigation("ProductsList");
                });

            modelBuilder.Entity("Sabzishop.Models.Products.Products", b =>
                {
                    b.Navigation("descount");
                });
#pragma warning restore 612, 618
        }
    }
}
