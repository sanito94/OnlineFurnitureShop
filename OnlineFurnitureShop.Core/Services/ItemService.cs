using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Models.Admin;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFurnitureShop.Core.Services
{
    public class ItemService : IItemService
    {
        private readonly IRepository repository;

        public ItemService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddItemAsync(ItemServiceModel model)
        {
            await repository.AddAsync(new Item()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                SubCategoryId = model.SubCategoryId,
                CategoryId = model.CategoryId,
            });

            await repository.SaveChangesAsync();
        }
    }
}
