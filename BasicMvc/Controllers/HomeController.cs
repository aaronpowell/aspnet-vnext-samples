using Microsoft.AspNet.Mvc;

namespace BasicMvc.Controllers {
    public class HomeController : Controller {
        public IActionResult Indux() {
            return View();
        }
    }
}