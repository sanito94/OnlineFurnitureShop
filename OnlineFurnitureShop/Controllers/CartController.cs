using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Models;
using OnlineFurnitureShop.Data;
using OnlineFurnitureShop.Extensions;
using OnlineFurnitureShop.Infrastructure.Data.Common;

namespace OnlineFurnitureShop.Controllers
{
    public class CartController : Controller
    {
        private readonly OnlineFurnitureShopDbContext context;

        public CartController(OnlineFurnitureShopDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> All()
        {
            var cart = await context.Carts
                .AsNoTracking()
                .Where(c => c.UserId == User.Id())
                .Select(c => new CartViewModel()
                {
                    Id = c.Id,
                    ItemName = c.ItemName,
                    ItemId = c.ItemId,
                    Amount = c.Amount,
                    ImageUrl = c.ImageUrl,
                    UserId = User.Id(),
                    Price = c.Price,
                })
                .ToListAsync();

            return View(cart);
        }
    }
}
