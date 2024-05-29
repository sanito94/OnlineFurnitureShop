using Microsoft.AspNetCore.Mvc;
using OnlineFurnitureShop.Core.Contracts;

namespace OnlineFurnitureShop.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        public async Task<IActionResult> AllUsers()
        {
            var model = await userService.AllAsync();

            return View(model);
        }
    }
}
