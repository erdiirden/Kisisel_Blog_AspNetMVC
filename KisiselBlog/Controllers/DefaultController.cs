using Microsoft.AspNetCore.Mvc;

namespace KisiselBlog.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
