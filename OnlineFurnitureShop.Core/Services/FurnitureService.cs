using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Enumerations;
using OnlineFurnitureShop.Core.Models;
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
    

    public class FurnitureService : IFurnitureService
    {
        private readonly IRepository repository;
        private readonly OnlineFurnitureShopDbContext context;

        public FurnitureService(
            IRepository _repository,
            OnlineFurnitureShopDbContext _context)
        {
            repository = _repository;
            context = _context;
        }


        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<ShopQueryServiceModel> AllItemsAsync(
            string? category = null, 
            string? subCategory = null,
            string? searchTerm = null, 
            FurnitureSorting sorting = FurnitureSorting.Newest,
            int currentPage = 1, 
            int itemsPerPage = 1)
        {
            var itemsQuery = repository.AllReadOnly<Item>();

            if (!string.IsNullOrWhiteSpace(category))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.Category.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(subCategory))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.SubCategory.Name == subCategory);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                itemsQuery = itemsQuery
                    .Where(h =>
                    h.Name.ToLower().Contains(searchTerm.ToLower()) ||
                    h.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            itemsQuery = sorting switch
            {
                FurnitureSorting.Price => itemsQuery
                .OrderBy(h => h.Price),
                _ => itemsQuery.OrderByDescending(h => h.Id)
            };

            var items = itemsQuery
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(i => new ShopServiceModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                })
                .ToList();

            var totalItems = items.Count();

            return new ShopQueryServiceModel()
            {
                TotalItemsCount = totalItems,
                Items = items,
            };
        }

		public async Task<IEnumerable<CartViewModel>> AllItemsInTheCart()
		{
			return await repository.AllReadOnly<Cart>()
				.Select(c => new CartViewModel
				{
					Id = c.Id,
                    ItemId = c.Id,
                    UserId = c.UserId,
					Amount = c.Amount,
				})
				.ToListAsync();
		}

		public async Task<IEnumerable<string>> AllSubCategoriesNamesAsync()
        {
            return await repository.AllReadOnly<SubCategory>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<CartViewModel> CartExistsAsync(string userId, int id)
        {
            return await repository.AllReadOnly<Cart>()
				.Where(c => c.UserId == userId && c.ItemId == id)
				.Select(c => new CartViewModel()
				{
					ItemId = c.Id,
					UserId = userId,
					ImageUrl = c.ImageUrl,
					Amount = c.Amount,
				})
				.FirstAsync();
		}

        public async Task<bool> CartExistsByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<Cart>()
                .Where(c => c.UserId == userId)
                .AnyAsync();
        }

        public async Task<IEnumerable<CartViewModel>> CartTotalAsync(string userId)
        {
            var model = await context.Carts
                .Where(c => c.UserId == userId)
                .Select(c => new CartViewModel()
                {
                    Id = c.Id,
                    ItemId = c.Id,
                    UserId = userId,
                    Amount = c.Amount,
                    ImageUrl = c.ImageUrl,
                    ItemName = c.ItemName,
                    Price = c.Price,
                    Total = c.Total,
                    SubTotal = c.SubTotal
                })
                .ToListAsync();

            return model;
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync<Cart>(id);
        }

        public async Task<ItemDetailsServiceModel> ItemDetailsByIdAsync(int id)
        {
            return await repository.AllReadOnly<Item>()
                .Where(i => i.Id == id)
                .Select(i => new ItemDetailsServiceModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                    Category = i.Category.Name,
                    SubCategory = i.SubCategory.Name
                })
                .FirstAsync();
        }

        public async Task<bool> ItemExistsByIdAsync(int id)
        {
            return await repository.AllReadOnly<Item>()
                .AnyAsync(i => i.Id == id);
        }

        public async Task<bool> ItemExistsInTheCartAsync(int id)
        {
            return await repository.AllReadOnly<Cart>()
                .AnyAsync(c => c.ItemId == id);
        }

        public async Task<IEnumerable<ShopIndexServiceModel>> LastThreeFurnituresAsync()
        {
            return await repository.AllReadOnly<Item>()
                .OrderByDescending(f => f.Id)
                .Select(f => new ShopIndexServiceModel
                {
                    Id = f.Id,
                    Name = f.Name,
                    Description = f.Description,
                    ImageUrl = f.ImageUrl,
                    Price = f.Price,
                })
                .Take(3)
                .ToListAsync();
        }

    }
}
