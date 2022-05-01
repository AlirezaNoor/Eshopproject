using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sabzishop.Models.BASKET;
using Sabzishop.Models.Category;
using Sabzishop.Models.Discount;
using Sabzishop.Models.Products;
using Sabzishop.Models.Slider;

namespace Sabzishop.Db_Context
{
    public class MyDb:IdentityDbContext
    {
        public DbSet<Slider> slider { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Descount> descount { get; set; }
        public DbSet<Basket> basket { get; set; }

        public MyDb(DbContextOptions<MyDb> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasData(
                new Slider()
                {
                    id = 1,
                    title = "تله فیزیون1",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },

                new Slider()
                {
                    id = 2,
                    title = "تله فیزیون2",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 3,
                    title = "تله فیزیون3",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 4,
                    title = "4تله فیزیون",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 5,
                    title = "تله فیزیون5",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 6,
                    title = "تله فیزیون6",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id=7,
                    title = "تله فیزیون7",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 8,
                    title = "تله فیزیون8",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                },
                new Slider()
                {
                    id = 9,
                    title = "9 فیزیون",
                    discription = "این یه نمونه برای شما که هستی ",
                    undertitle = "شپولی جونم"
                }

            );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                id = 1,
                name = "گوشی"
                },
                new Category()
                {
                    id = 2,
                    name = "لپ تاپ"
                },
                new Category()
                {
                    id = 3,
                    name = "تبلت"
                },
                new Category()
                {
                    id = 4,
                    name = "هدفون و هدست"
                },
                new Category()
                {
                    id = 5,
                    name = "کنسول بازی"
                }
            );

            modelBuilder.Entity<Products>().HasData(
                
                new Products()
                {
                    id = 1,
                    name = "گوشی موبایل Xiaomi Mi 9",
                    discriptio = "یک گوشی مناسب وارزان",
                    price = 350000,
                    categoryid = 1,
                    ISspesial = true,
                    instroe = 4,
                   

                },
                new Products()
                {
                    id = 2,
                    name = "هندزفری بی سیم Sony",
                    discriptio = "یک هنسفری مناسب ",
                    price = 3800,
                    categoryid = 4,
                    ISspesial = false,
                    instroe = 3
                },
                new Products()
                {
                    id = 3,
                    name = "دسته بازی PS4",
                    discriptio = "عرصه بازی های اولیه در ایران ",
                    price = 3800,
                    categoryid = 5,
                    ISspesial = false,
                    instroe = 3
                },
                new Products()
                {
                    id = 4,
                    name = "هندزفری بلوتوثی بی سیم Xiaomi iBfree",
                    discriptio = "هندزفری بلوتوثی بی سیم Xiaomi iBfree ",
                    price = 790000,
                    categoryid = 4,
                    ISspesial = true,
                    instroe = 15,
                    descountid =1, 
                },
                new Products()
                {
                    id = 13,
                    name = "هدفون حرفه ای گیمینگ Beats",
                    discriptio = "هدفون حرفه ای گیمینگ Beats ",
                    price = 790000,
                    categoryid = 2,
                    ISspesial = true,
                    instroe = 15,
               
                      
                },
                new Products()
                {
                    id = 5,
                    name = "گوشی آیفون",
                    discriptio = "گوشی آیفون  ",
                    price = 350000,
                    categoryid = 1,
                    ISspesial = true,
                    instroe = 10
                },
                new Products()
                {
                    id = 6,
                    name = "گوشی شیاموی رد می",
                    discriptio = "گوشی شیاموی رد می",
                    price = 350000,
                    categoryid = 1,
                    ISspesial = false,
                    instroe = 15
                },
                new Products()
                {
                    id =7,
                    name = "هدفون حرفه ای گیمینگ Beats",
                    discriptio = "هدفون حرفه ای گیمینگ Beats ",
                    price = 790000,
                    categoryid = 2,
                    ISspesial = true,
                    instroe = 15,
                    descountid = 2,
                },
                new Products()
                {
                    id = 8,
                    name = "کنسول pes4",
                    discriptio = "کنسول زیبا برای شما",
                    price = 790000,
                    categoryid = 5,
                    ISspesial = false,
                    instroe = 15,
                    descountid = 3,
                },
                new Products()
                {
                    id = 9,
                    name = "اسپیکر بلوتوثی قابل حمل Anker",
                    discriptio = "اسپیکر بلوتوثی قابل حمل Anker",
                    price = 200000,
                    categoryid = 4,
                    ISspesial = false,
                    instroe = 15
                },
                new Products()
                {
                    id =10,
                    name = "لپ تاپ شیامی",
                    discriptio = "لپ اپ های زیبا روی ایران",
                    price = 1200000,
                    categoryid =2,
                    ISspesial = true,
                    instroe = 15,
                    descountid = 4,
                },
                new Products()
                {
                    id = 11,
                    name = "تبلت های زیبا ",
                    discriptio = "تبلت های های زیبا",
                    price = 1200000,
                    categoryid = 3,
                    ISspesial = false,
                    instroe = 15,
                    descountid = 5,
                },
                new Products()
                {
                    id = 12,
                    name = "تبلت های آسوز",
                    discriptio = "تبلت های های زیبا",
                    price = 1200000,
                    categoryid = 3,
                    ISspesial = true,
                    instroe = 15
                }
                );
            modelBuilder.ApplyConfiguration(new ModelMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new DescountMapping());

            modelBuilder.Entity<Descount>().HasData(
                
                new Descount()
                {
                    id = 1,
                    now = DateTime.Now,
                    enddes = new DateTime(2022, 5, 2, 5, 10, 20),
                    pricedes = 590000,
                    proid = 4,

                },
                new Descount()
                {
                    id = 2,
                    now = DateTime.Now,
                    enddes = new DateTime(2022, 5, 1, 5, 10, 20),
                    pricedes = 490000,
                    proid = 7,
                    
                },
                new Descount()
                {
                    id = 3,
                    now = DateTime.Now,
                    enddes = new DateTime(2022, 5, 3, 5, 10, 20),
                    pricedes = 390000,
                    proid = 8,

                },
                new Descount()
                {
                    id = 4,
                    now = DateTime.Now,
                    enddes = new DateTime(2022, 5, 4, 5, 10, 20),
                    pricedes = 490000,
                    proid = 10,

                },
                new Descount()
                {
                    id = 5,
                    now = DateTime.Now,
                    enddes = new DateTime(2022, 5, 2, 5, 10, 20),
                    pricedes = 990000,
                    proid = 11,

                }

                );
        
            base.OnModelCreating(modelBuilder);

        }
        
    }
}
