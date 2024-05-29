using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineFurnitureShop.Core.Models.Admin
{
    public class SubCategoryServiceModel
    {
        public SubCategoryServiceModel()
        {
            Category = new List<CategoryServiceModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryServiceModel> Category { get; set; }
    }
}
