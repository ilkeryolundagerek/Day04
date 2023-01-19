using Microsoft.AspNetCore.Mvc;

namespace MVCTemplate.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]//Ait olduğu Area bilgisi sayesinde aynı isimli controller yapıları çakışmaz.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
