using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Infrastructure.Data.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public DateTime TimeOfPick { get; set; }
        public DateTime DateOfPick { get; set; }
        public double SubTotal { get; set; }
        public double OrderTotal { get; set; }
        public string CouponCode { get; set; } = string.Empty;
        public double CouponDiscount { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

    }
}
