using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Models
{
    public class CategoryRepo:ICategoryRepo
    {
        private readonly PaintingDbContext _paintingDbContext;

        public CategoryRepo(PaintingDbContext paintingDbContext)
        {
            _paintingDbContext = paintingDbContext;
        }

        public IEnumerable<Category> AllCategories => _paintingDbContext.Categories;
  }
}
