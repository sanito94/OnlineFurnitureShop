using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Models
{
    public class ItemDetailsServiceModel : ShopServiceModel
    {
        public string Category { get; set; } = null!;
        public string SubCategory { get; set; } = null!;
    }
}
