﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sabzishop.Db_Context;

namespace Sabzishop.Migrations
{
    [DbContext(typeof(MyDb))]
    partial class MyDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sabzishop.Models.BASKET.Basket", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Productsid")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("proid")
                        .HasColumnType("bigint");

                    b.Property<long>("tedad")
                        .HasColumnType("bigint");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("Productsid");

                    b.HasIndex("userid");

                    b.ToTable("basket");
                });

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
                            now = new DateTime(2022, 5, 1, 10, 25, 54, 968, DateTimeKind.Local).AddTicks(599),
                            pricedes = 590000m,
                            proid = 4L
                        },
                        new
                        {
                            id = 2L,
                            enddes = new DateTime(2022, 5, 1, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1709),
                            pricedes = 490000m,
                            proid = 7L
                        },
                        new
                        {
                            id = 3L,
                            enddes = new DateTime(2022, 5, 3, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1792),
                            pricedes = 390000m,
                            proid = 8L
                        },
                        new
                        {
                            id = 4L,
                            enddes = new DateTime(2022, 5, 4, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1804),
                            pricedes = 490000m,
                            proid = 10L
                        },
                        new
                        {
                            id = 5L,
                            enddes = new DateTime(2022, 5, 2, 5, 10, 20, 0, DateTimeKind.Unspecified),
                            now = new DateTime(2022, 5, 1, 10, 25, 54, 973, DateTimeKind.Local).AddTicks(1810),
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sabzishop.Models.BASKET.Basket", b =>
                {
                    b.HasOne("Sabzishop.Models.Products.Products", "Products")
                        .WithMany("basket")
                        .HasForeignKey("Productsid");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("userid");

                    b.Navigation("Products");

                    b.Navigation("User");
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
                    b.Navigation("basket");

                    b.Navigation("descount");
                });
#pragma warning restore 612, 618
        }
    }
}
