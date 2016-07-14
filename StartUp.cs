using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Com.Lengzzz.ThumbNet {
    public class Startup {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory) {
            loggerFactory.AddDebug();
            if (env.IsDevelopment()) {
                app.useDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            } else {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();
            app.UseIdentity();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "index",
                    template: "{controller=index}/{action=index}/{id?}"
                );
            });
        }
    }
}
