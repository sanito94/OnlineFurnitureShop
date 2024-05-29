using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Models.Admin;
using OnlineFurnitureShop.Data;

namespace OnlineFurnitureShop.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly ICategoryService categoryService;
        private readonly IItemService itemService;
        private readonly OnlineFurnitureShopDbContext context;

        public HomeController(ICategoryService _categoryService,
            OnlineFurnitureShopDbContext _context,
            IItemService _itemService)
        {
            categoryService = _categoryService;
            context = _context;
            itemService = _itemService;
        }

        public IActionResult DashBoard()
        {
            return View();
        }

        public async Task<IActionResult> AddCategory()
        {
            var model = new CategoryServiceModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryServiceModel model)
        {
            await categoryService.AddCategoryAsync(model.Name);

            return RedirectToAction(nameof(DashBoard));
        }

        public async Task<IActionResult> AddSubCategory()
        {
            var model = new SubCategoryServiceModel();

            model.Category = await categoryService.AllCategoriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddSubCategory(SubCategoryServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Category = await categoryService.AllCategoriesAsync();

                return View(model);
            }

            await categoryService.AddSubCategoryAsync(model);

            return RedirectToAction(nameof(DashBoard));
        }

        public async Task<IActionResult> AddItem()
        {
            var model = new ItemServiceModel();

            model.Category = await categoryService.AllCategoriesAsync();
            model.SubCategory = await categoryService.AllSubCategoriesAsync(model.SubCategoryId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(ItemServiceModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Category = await categoryService.AllCategoriesAsync();
                model.SubCategory = await categoryService.AllSubCategoriesAsync(model.SubCategoryId);

                return View(model);
            }

            await itemService.AddItemAsync(model);

            return RedirectToAction(nameof(DashBoard));
        }
    }
}
