using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Models;
using OnlineFurnitureShop.Data;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using OnlineFurnitureShop.Models;
using System.Diagnostics;

namespace OnlineFurnitureShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFurnitureService furnitureService;

        public HomeController(
            ILogger<HomeController> logger,
            IFurnitureService _furnitureService)
        {
            _logger = logger;
            furnitureService = _furnitureService;
        }

        public async Task<IActionResult> Index()
        {
            var furniture = await furnitureService.LastThreeFurnituresAsync();

            return View(furniture);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}