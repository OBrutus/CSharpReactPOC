using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EkamArtMBProj.Models;

namespace EkamArtMBProj.Models
{
    public class PaintingDbContext:DbContext
    {
        public PaintingDbContext(DbContextOptions<PaintingDbContext> options):base(options)
        {

        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding the db
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Watercolor", Description = "The most versatile and fresh medium" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Acrylic", Description = "The most versatile and fresh medium" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gouache", Description = "The most versatile and fresh medium" });

            modelBuilder.Entity<Painting>().HasData(

                 new Painting
                 {
                     PaintingId = 1,
                     Name = "Diagon Alley",
                     Price = 15000,
                     ShortDescription = "Lorem Ipsum",
                     LongDescription = "A Beautiful painting that can enhance your home space!",
                     CategoryId = 1,
                     ImageUrl = "/images/Alley.jpg",
                     InStock = true,
                     IsPaintingOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Alley.jpg"
                 });

            modelBuilder.Entity<Painting>().HasData(

          new Painting
          {
              PaintingId = 2,
              Name = "Portrait of a Sadhu",
              Price = 10000,
              ShortDescription = "Lorem Ipsum",
              LongDescription = "A Beautiful painting that can enhance your home space!",
              CategoryId = 2,
              ImageUrl = "/images/saadhu.jpg",
              InStock = true,
              IsPaintingOfTheWeek = false,
              ImageThumbnailUrl = "/images/saadhu.jpg"
          });
            modelBuilder.Entity<Painting>().HasData(
           new Painting
           {
               PaintingId = 3,
               Name = "Stairway to Heaven",
               Price = 20000,
               ShortDescription = "Lorem Ipsum",
               LongDescription = "A Beautiful painting that can enhance your home space!",
               CategoryId = 3,
               ImageUrl = "/images/Well.jpg",
               InStock = true,
               IsPaintingOfTheWeek = false,
               ImageThumbnailUrl = "/images/Well.jpg"
           });


           
            modelBuilder.Entity<Painting>().HasData(
                new Painting
                {
                    PaintingId = 4,
                    Name = "Greece Magic",
                    Price = 8500,
                    ShortDescription = "Lorem Ipsum",
                    LongDescription = "A Beautiful painting that can enhance your home space!",
                    CategoryId = 2,
                    ImageUrl = "/images/Greece.jpg",
                    InStock = true,
                    IsPaintingOfTheWeek = true,
                    ImageThumbnailUrl = "/images/Greece.jpg"
                });

            modelBuilder.Entity<Painting>().HasData(
                new Painting
                {
                    PaintingId = 5,
                    Name = "Sunset Skies",
                    Price = 19500,
                    ShortDescription = "Lorem Ipsum",
                    LongDescription = "A Beautiful painting that can enhance your home space!",
                    CategoryId = 2,
                    ImageUrl = "/images/boat.jpeg",
                    InStock = true,
                    IsPaintingOfTheWeek = true,
                    ImageThumbnailUrl = "/images/boat.jpeg"
                });

            modelBuilder.Entity<Painting>().HasData(
                new Painting
                {
                    PaintingId = 6,
                    Name = "Sunriched",
                    Price = 12000,
                    ShortDescription = "Lorem Ipsum",
                    LongDescription = "A Beautiful painting that can enhance your home space!",
                    CategoryId = 1,
                    ImageUrl = "/images/Sunflowers.png",
                    InStock = true,
                    IsPaintingOfTheWeek = true,
                    ImageThumbnailUrl = "/images/Sunflowers.png"
                });

            modelBuilder.Entity<Painting>().HasData(
              new Painting
              {
                  PaintingId = 7,
                  Name = "Bloom",
                  Price = 12000,
                  ShortDescription = "Lorem Ipsum",
                  LongDescription = "A Beautiful painting that can enhance your home space!",
                  CategoryId = 1,
                  ImageUrl = "/images/lotus3.jpg",
                  InStock = true,
                  IsPaintingOfTheWeek = true,
                  ImageThumbnailUrl = "/images/lotus3.png"
              });

            modelBuilder.Entity<Painting>().HasData(
              new Painting
              {
                  PaintingId = 8,
                  Name = "Bloom again",
                  Price = 12000,
                  ShortDescription = "Lorem Ipsum",
                  LongDescription = "A Beautiful painting that can enhance your home space!",
                  CategoryId = 1,
                  ImageUrl = "/images/Lilly.jpg",
                  InStock = true,
                  IsPaintingOfTheWeek = true,
                  ImageThumbnailUrl = "/images/Lilly.jpg"
              });

            modelBuilder.Entity<Painting>().HasData(
              new Painting
              {
                  PaintingId = 9,
                  Name = "Blue Beauty",
                  Price = 12000,
                  ShortDescription = "Lorem Ipsum",
                  LongDescription = "A Beautiful painting that can enhance your home space!",
                  CategoryId = 1,
                  ImageUrl = "/images/peacock2.jpeg",
                  InStock = true,
                  IsPaintingOfTheWeek = false,
                  ImageThumbnailUrl = "/images/peacock2.jpeg"
              });
        }


        public DbSet<EkamArtMBProj.Models.Order> Order { get; set; }

    }
}
