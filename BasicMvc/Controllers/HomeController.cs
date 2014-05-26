using Microsoft.AspNet.Mvc;

namespace BasicMvc.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}