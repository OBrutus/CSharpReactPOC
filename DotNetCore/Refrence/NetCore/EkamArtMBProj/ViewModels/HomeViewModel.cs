using EkamArtMBProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Painting> PaintingsOfTheWeek { get; set; }
    }
}
