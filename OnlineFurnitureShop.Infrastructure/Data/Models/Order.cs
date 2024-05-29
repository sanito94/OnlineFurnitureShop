using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; } = null!;
        public bool Status { get; set; }
    }
}
