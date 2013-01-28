using System.Web.Mvc;

namespace POC.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }
}
