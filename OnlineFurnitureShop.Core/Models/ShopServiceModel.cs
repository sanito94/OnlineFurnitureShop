using OnlineFurnitureShop.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using static OnlineFurnitureShop.Core.Constants.MessageConstants;
using static OnlineFurnitureShop.Infrastructure.Constants.DataConstants;

namespace OnlineFurnitureShop.Core.Models
{
    public class ShopServiceModel : IItemModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ItemNameMaxLength,
            MinimumLength = ItemNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ItemDescriptionMaxLength,
            MinimumLength = ItemDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(double),
            ItemPriceMinLength,
            ItemPriceMaxLength,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price must be a positive number and less than {2}$")]
        public double Price { get; set; }

        [Display(Name = "Image URL")]
        [Required(ErrorMessage = RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        public int Amount { get; set; } = 1;
    }
}