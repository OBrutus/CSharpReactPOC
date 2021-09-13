using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
   public interface IPaintingRepo
    {
        IEnumerable<Painting> Allpaintings { get; }
       // IEnumerable<Painting> PaintingsOfTheWeek { get; set; }
        Painting GetPaintingById();
    }
}
