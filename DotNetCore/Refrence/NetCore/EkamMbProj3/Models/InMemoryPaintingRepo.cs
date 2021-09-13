using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class InMemoryPaintingRepo : IPaintingRepo
    {
        List<Painting> _paintings;
        public InMemoryPaintingRepo()
        {
            _paintings = new List<Painting>
            {
                new Painting{  
                    PaintingId = 1,
                     Name = " Alley",
                     Price = 15000,
                     ShortDescription = "Lorem Ipsum",
                     LongDescription = "A Beautiful painting that can enhance your home space!",
                     CategoryId = 1,
                     ImageUrl = "/images/Alley.jpg",
                     InStock = true,
                     IsPaintingOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Alley.jpg"},
                new Painting{PaintingId = 2,
                    Name = " Sadhu",
                    Price = 10000,
                    ShortDescription = "Lorem Ipsum",
                    LongDescription = "A Beautiful painting that can enhance your home space!",
                    CategoryId = 2,
                    ImageUrl = "/images/saadhu.jpg",
                    InStock = true,
                    IsPaintingOfTheWeek = false, 
                    ImageThumbnailUrl = "/images/saadhu.jpg"},
                new Painting{ PaintingId = 3,
                    Name = "Stairway ",
                    Price = 20000,
                    ShortDescription = "Lorem Ipsum",
                    LongDescription = "A Beautiful painting that can enhance your home space!",
                    CategoryId = 3,
                    ImageUrl = "/images/Well.jpg",
                    InStock = true,
                    IsPaintingOfTheWeek = false,
                    ImageThumbnailUrl = "/images/Well.jpg"},
            };
        }

        public IEnumerable<Painting> Allpaintings
        {
            get
            {
                return _paintings;
            }
        }

        public IEnumerable<Painting> PaintingsOfTheWeek { get { return _paintings; } }

        IEnumerable<Painting> IPaintingRepo.PaintingsOfTheWeek { get => throw new NotImplementedException();  }

        public Painting GetPaintingById()
        {
            throw new NotImplementedException();
        }

        public Painting GetPaintingById(int paintingId)
        {
            throw new NotImplementedException();
        }
    }
}
