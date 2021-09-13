using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemid { get; set; }
        public Painting Painting { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
