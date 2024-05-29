using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineFurnitureShop.Infrastructure.Constants.DataConstants;


namespace OnlineFurnitureShop.Infrastructure.Data.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameLength)]
        public string Name { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}
