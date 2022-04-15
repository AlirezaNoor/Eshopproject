using Microsoft.EntityFrameworkCore;
using Sabzishop.Models.Slider;

namespace Sabzishop.Db_Context
{
    public class MyDb:DbContext
    {
        public DbSet<Slider> slider { get; set; }
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
        }
    }
}
