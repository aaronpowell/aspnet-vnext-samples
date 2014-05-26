using Microsoft.AspNet.Builder;

namespace BasicWeb {
    public class Startup {
        public void Configure(IBuilder builder) {
/*
            builder.MapWhen(
                context => context.Request.Path.Value.Contains("home"),
                app => app.Run(async context => {
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync("Hello World");
                })
            );
*/

            builder.UseWelcomePage();
        }
    }
}