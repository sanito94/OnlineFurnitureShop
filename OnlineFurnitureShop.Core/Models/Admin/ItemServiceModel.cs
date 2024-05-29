using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Models.Admin
{
    public class ItemServiceModel
    {
        public ItemServiceModel()
        {
            SubCategory = new List<SubCategoryServiceModel>();
            Category = new List<CategoryServiceModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<SubCategoryServiceModel> SubCategory { get; set; }
        public IEnumerable<CategoryServiceModel> Category { get; set; }
    }
}
