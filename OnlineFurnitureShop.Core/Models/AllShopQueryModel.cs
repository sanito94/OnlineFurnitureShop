using OnlineFurnitureShop.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineFurnitureShop.Core.Models
{
    public class AllShopQueryModel
    {
        public AllShopQueryModel()
        {
            Items = new List<ShopServiceModel>();
        }

        public int ItemsPerPage { get; } = 3;

        public string Category { get; init; } = null!;

        public string SubCategory { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;

        public FurnitureSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int PageOne { get; set; } = 1;

        public int TotalItemsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<string> SubCategories { get; set; } = null!;

        public IEnumerable<ShopServiceModel> Items { get; set; }
    }
}
