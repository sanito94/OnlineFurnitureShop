using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Contracts
{
    public interface IItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
