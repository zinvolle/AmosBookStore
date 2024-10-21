using Microsoft.AspNetCore.Mvc;

namespace AmosBooks.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
