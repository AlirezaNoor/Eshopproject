using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sabzishop.Models.BASKET;
using Sabzishop.Models.Category;
using Sabzishop.Models.Discount;
using Sabzishop.Models.Products;

namespace Sabzishop
{
    public class ModelMapping : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.id);
            builder.Property(x => x.discriptio).IsRequired();
            builder.Property(x => x.instroe).IsRequired();
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.price).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.ProductsList).HasForeignKey(x => x.categoryid);
            builder.HasOne(x => x.descount).WithOne(x => x.Products).HasForeignKey<Products>(x => x.descountid);
        }
    }

    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.HasMany(x => x.ProductsList).WithOne(x => x.Category).HasForeignKey(x => x.categoryid);
        }
    }

    public class DescountMapping :IEntityTypeConfiguration<Descount>
    {
        public void Configure(EntityTypeBuilder<Descount> builder)
        {
            builder.ToTable("Descount");
            builder.HasKey(x => x.id);
            builder.Property(x => x.now).IsRequired();
            builder.Property(x => x.enddes).IsRequired();
            builder.Property(x => x.pricedes).IsRequired();
            builder.HasOne(x => x.Products).WithOne(x => x.descount).HasForeignKey<Descount>(x=>x.proid);
        }
    }
    public class BasketMapping : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.price).IsRequired();
            builder.Property(x => x.proid).IsRequired();
            builder.Property(x => x.tedad).IsRequired();
            builder.Property(x => x.userid).IsRequired();
            builder.HasOne(x => x.Products).WithMany(x => x.basket).HasForeignKey(x => x.proid);
        }
    }
}
