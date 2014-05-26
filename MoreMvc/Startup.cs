using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;

namespace MoreMvc {
    public class Startup {
        public void Configure(IBuilder builder) {
            builder.UseErrorPage();

            builder.UseServices(s => {
                s.AddMvc();

                var config = new Configuration()
                    .AddJsonFile("App_Data\\config.json")
                    .AddEnvironmentVariables();

                s.AddInstance<IConfiguration>(config);
            });

            builder.UseMvc();

            builder.UseWelcomePage();
        }
    }
}