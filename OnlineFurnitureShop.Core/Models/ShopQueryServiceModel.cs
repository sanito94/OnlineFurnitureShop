using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Models
{
    public class ShopQueryServiceModel
    {
        public ShopQueryServiceModel()
        {
            Items = new List<ShopServiceModel>();
        }

        public int TotalItemsCount { get; set; }
        public IEnumerable<ShopServiceModel> Items { get; set; }
    }
}
