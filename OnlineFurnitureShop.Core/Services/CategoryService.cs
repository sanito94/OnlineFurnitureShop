using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Models.Admin;
using OnlineFurnitureShop.Data;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;
        private readonly OnlineFurnitureShopDbContext context;

        public CategoryService(IRepository _repository,
            OnlineFurnitureShopDbContext _context)
        {
            repository = _repository;
            context = _context;
        }

        public async Task AddCategoryAsync(string name)
        {
            await repository.AddAsync(new Category()
            {
                Name = name,
            });

            await repository.SaveChangesAsync();
        }

        public async Task AddSubCategoryAsync(SubCategoryServiceModel model)
        {
            await repository.AddAsync(new SubCategory()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
            });

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryServiceModel>> AllCategoriesAsync()
        {
            return await context.Categories
                .AsNoTracking()
                .Select(c => new CategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<SubCategoryServiceModel>> AllSubCategoriesAsync(int categoryId)
        {
            return await context.SubCategories
                .AsNoTracking()
                .Select(c => new SubCategoryServiceModel()
                {
                   Id = c.Id,
                   Name = c.Name,
                   CategoryId = categoryId
                })
                .ToListAsync();
        }
    }
}
