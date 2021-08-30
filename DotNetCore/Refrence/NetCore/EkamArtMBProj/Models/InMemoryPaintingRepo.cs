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
                new Painting{id=1,Name="Sunset at Malvern",Price=40000},
                new Painting{id=2,Name="Peacock Portrait",Price=40000},
                new Painting{id=3,Name="Koi in a pond",Price=40000},
            };
        }
        public IEnumerable<Painting> GetAllPaintings()
        {
            return _paintings.OrderBy(r => r.Name);
        }
    }
}
