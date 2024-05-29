using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Extensions;
using OnlineFurnitureShop.Core.Models;
using OnlineFurnitureShop.Data;
using OnlineFurnitureShop.Extensions;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;

namespace OnlineFurnitureShop.Controllers
{
    public class ShopController : BaseController
    {
        private readonly IRepository repository;
        private readonly IFurnitureService furnitureService;
        private readonly OnlineFurnitureShopDbContext context;

        public ShopController(IFurnitureService _furnitureService,
            IRepository _repository,
            OnlineFurnitureShopDbContext _context)
        {
            furnitureService = _furnitureService;
            repository = _repository;
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllShopQueryModel query)
        {
            var queryResult = await furnitureService.AllItemsAsync(
                query.Category,
                query.SubCategory,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                query.ItemsPerPage);

            query.TotalItemsCount = queryResult.TotalItemsCount;
            query.Items = queryResult.Items;

            var shopCategories = await furnitureService.AllCategoriesNamesAsync();
            var shopSubCategories = await furnitureService.AllSubCategoriesNamesAsync();

            query.Categories = shopCategories;
            query.SubCategories = shopSubCategories;

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, string information)
        {
            if (await furnitureService.ItemExistsByIdAsync(id) == false)
            {
                return BadRequest();
            }

            var item = await furnitureService.ItemDetailsByIdAsync(id);

            if (information != item.GetInformation())
            {
                return BadRequest();
            }

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCard(int id)
        {
            if (await furnitureService.ItemExistsByIdAsync(id) == false)
            {
                return BadRequest();
            }

            string userId = User.Id();

			var item = await furnitureService.ItemDetailsByIdAsync(id);

            if (item == null)
            {
                return BadRequest();
            }

			var cart = await repository.AllReadOnly<Cart>()
                .Where(c => c.UserId == userId && c.ItemId == id)
                .FirstOrDefaultAsync();

			if (cart == null)
            {
                var cartCreate = new Cart()
                {
                    ItemId = id,
                    ItemName = item.Name,
                    UserId = userId,
                    ImageUrl = item.ImageUrl,
                    Price = item.Price,
                    Amount = item.Amount,
                    Total = item.Price * item.Amount
                };

                await repository.AddAsync(cartCreate);
                await repository.SaveChangesAsync();
				return RedirectToAction("All", "Cart");
			}

			cart.Amount += 1;
            cart.Price += item.Price;
			await repository.SaveChangesAsync();
			return RedirectToAction("All", "Cart");
		}

        [HttpPost]
        public async Task<IActionResult> PlusAmount(int id)
        {
            var shoppingCartItem = await context.Carts
                .Where(c => c.UserId == User.Id() && c.ItemId == id)
                .FirstOrDefaultAsync();

            if (shoppingCartItem != null)
            {
                shoppingCartItem.Amount++;
                shoppingCartItem.Total = shoppingCartItem.Amount * shoppingCartItem.Price;

                await context.SaveChangesAsync();

                var model = await furnitureService.CartTotalAsync(User.Id());

                double subTotal = 0;

                foreach (var item in model)
                {
                    subTotal += item.Total;
                }

                var itemWithSubTotalValue = await context.Carts
                .Where(c => c.UserId == User.Id() && c.SubTotal > 0)
                .FirstOrDefaultAsync();

                if (itemWithSubTotalValue != null)
                {
                    itemWithSubTotalValue.SubTotal = subTotal;
                }
                else
                {
                    shoppingCartItem.SubTotal = subTotal;
                }
                
            }

            await context.SaveChangesAsync();
            return RedirectToAction("All", "Cart");
        }

        [HttpPost]
        public async Task<IActionResult> MinusAmount(int id)
        {
            var shoppingCartItem = await context.Carts
                .Where(c => c.UserId == User.Id() && c.ItemId == id)
                .FirstOrDefaultAsync();

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount == 1)
                {
                    await furnitureService.DeleteAsync(shoppingCartItem.Id);
                }
                else
                {
                    shoppingCartItem.Amount--;
                    shoppingCartItem.Total = shoppingCartItem.Amount * shoppingCartItem.Price;

                    await context.SaveChangesAsync();

                    var model = await furnitureService.CartTotalAsync(User.Id());

                    double subTotal = 0;

                    foreach (var item in model)
                    {
                        subTotal += item.Total;
                    }

                    var itemWithSubTotalValue = await context.Carts
                    .Where(c => c.UserId == User.Id() && c.SubTotal > 0)
                    .FirstOrDefaultAsync();

                    if (itemWithSubTotalValue != null)
                    {
                        itemWithSubTotalValue.SubTotal = subTotal;
                    }
                    else
                    {
                        shoppingCartItem.SubTotal = subTotal;
                    }
                }
            }

            await context.SaveChangesAsync();
            return RedirectToAction("All", "Cart");
        }
    }
}
