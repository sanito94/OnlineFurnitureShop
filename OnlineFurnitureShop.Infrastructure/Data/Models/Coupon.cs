using System.ComponentModel.DataAnnotations;

namespace OnlineFurnitureShop.Infrastructure.Data.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        public double Discount { get; set; }
        public double MinimumAmount { get; set; }
        public byte[] CouponPicture { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
