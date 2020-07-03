using Microsoft.AspNetCore.Mvc;

namespace vassilyev.eSport.Web.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
    }
}
