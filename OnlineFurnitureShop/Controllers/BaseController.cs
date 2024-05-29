using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineFurnitureShop.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
