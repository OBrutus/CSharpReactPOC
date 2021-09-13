using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class InMemoryCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Watercolor",Description="The most versatile and fresh medium"},
            new Category{CategoryId=2,CategoryName="Acrylics",Description="The most used popular art medium - a marriage between Oil & Watercolors"},
            new Category{CategoryId=3,CategoryName="Oil",Description="Go the Masters way!Oil paintings are always cherished treasures!"},

        };
    }
}
