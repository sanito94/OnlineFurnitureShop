using OnlineFurnitureShop.Core.Models.Admin;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Contracts
{
    public interface ICategoryService
    {
        Task AddSubCategoryAsync(SubCategoryServiceModel model);

        Task<IEnumerable<CategoryServiceModel>> AllCategoriesAsync();

        Task<IEnumerable<SubCategoryServiceModel>> AllSubCategoriesAsync(int categoryId);

        Task AddCategoryAsync(string name);
    }
}
