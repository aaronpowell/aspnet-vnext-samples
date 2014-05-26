using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace BasicMvc {
    public class Startup {
        public void Configure(IBuilder builder) {
            builder.UseErrorPage();

            builder.UseServices(s => {
                s.AddMvc();
            });

            builder.UseMvc();

            builder.UseWelcomePage();
        }
    }
}