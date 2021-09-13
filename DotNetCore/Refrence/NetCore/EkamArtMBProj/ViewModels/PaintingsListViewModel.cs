using EkamArtMBProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.ViewModels
{
    public class PaintingsListViewModel
    {
        public IEnumerable<Painting> Paintings { get; set; }

        public string CurrentCategory { get; set; }
    }
}
