using Microsoft.AspNetCore.Mvc;

namespace pagina.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
