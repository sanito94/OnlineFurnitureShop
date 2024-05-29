using System.ComponentModel.DataAnnotations;
using static OnlineFurnitureShop.Infrastructure.Constants.DataConstants;

namespace OnlineFurnitureShop.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameLength)]
        public string Name { get; set; } = string.Empty;
    }
}
