using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class PaintingDbContext:DbContext
    {
        public PaintingDbContext(DbContextOptions<PaintingDbContext> options):base(options)
        {

        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Category> Categories { get; set; }


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
          
        }

    }
}
