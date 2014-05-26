using System.Text;
using Microsoft.AspNet.Mvc;

namespace MoreMvc {
    public class ApiController {
        private readonly IActionResultHelper result;
        private readonly ActionContext ctx;

        public ApiController(IActionResultHelper result, ActionContext ctx) {
            this.result = result;
            this.ctx = ctx;
        }

        public IActionResult Json() {
            return result.Json(new {
                Name = "Aaron",
                Awesomeness = "High"
            });
        }

        public IActionResult Content() {
            return result.Content("text/plain", "Let's still return some plain text", Encoding.UTF8);
        }
    }
}