using Microsoft.Framework.ConfigurationModel;

namespace MoreMvc {
    public class ConfigController {
        public readonly IConfiguration config;

        public ConfigController(IConfiguration config) {
            this.config = config;
        }

        public string Index() {
            var name = config.Get("name");
            var env = config.Get("env");
            var crap = config.Get("something:really:nested");

            return string.Format("Hello {0}, you're on the '{1}' environment and there's some crap really nested in the config: {2}", name, env, crap);
        }
    }
}