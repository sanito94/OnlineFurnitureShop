using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static OnlineFurnitureShop.Core.Constants.RoleConstants;

namespace OnlineFurnitureShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
    }
}
