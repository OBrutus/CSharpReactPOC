using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class PaintingRepo : IPaintingRepo
    {
        private readonly PaintingDbContext _paintingDbContext;

        public PaintingRepo(PaintingDbContext paintingDbContext)
        {
            _paintingDbContext = paintingDbContext;
        }

      
        public IEnumerable<Painting> Allpaintings
        {
            get
            {
                return _paintingDbContext.Paintings.Include(c => c.Category);
            }
        }

        public IEnumerable<Painting> PaintingsOfTheWeek {
            get {
                return _paintingDbContext.Paintings.Include(c => c.Category).Where(p => p.IsPaintingOfTheWeek);
            }
        }

        public Painting GetPaintingById(int paintingId)
        {
            return Allpaintings.FirstOrDefault(p => p.PaintingId == paintingId);
        }

    }

}