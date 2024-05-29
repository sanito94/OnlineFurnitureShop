using OnlineFurnitureShop.Core.Enumerations;
using OnlineFurnitureShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Contracts
{
    public interface IFurnitureService
    {
        Task<IEnumerable<ShopIndexServiceModel>> LastThreeFurnituresAsync();

        Task<ShopQueryServiceModel> AllItemsAsync(
            string? category = null,
            string? subCategory = null,
            string? searchTerm = null,
            FurnitureSorting sorting = FurnitureSorting.Newest,
            int currentPage = 1,
            int itemsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<string>> AllSubCategoriesNamesAsync();

        Task<bool> ItemExistsByIdAsync(int id);

        Task<ItemDetailsServiceModel> ItemDetailsByIdAsync(int id);
        
        Task<CartViewModel> CartExistsAsync(string userId, int id);

        Task<bool> ItemExistsInTheCartAsync(int id);

		Task<IEnumerable<CartViewModel>> AllItemsInTheCart();

        Task DeleteAsync(int id);

        Task<IEnumerable<CartViewModel>> CartTotalAsync(string userId);
    }
}
