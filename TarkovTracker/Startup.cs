﻿using ElectronNET.API;
using TarkovTracker.Data;

namespace TarkovTracker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpContextAccessor();

            //services.AddScoped<StateContainer>();

            if (HybridSupport.IsElectronActive)
            {
                services.AddElectron();
            }

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseWebSockets();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            if (HybridSupport.IsElectronActive)
            {
                Task.Run(async () =>
				{
                    // Move to own thread to reduce blocking (is technically still blocking?)
					await Cache.LoadCache();
				});
                Task.Run(async () =>
                {
                    var window = await Electron.WindowManager.CreateWindowAsync();
                    window.SetMinimumSize(1280, 720);
                    window.SetSize(1280, 720);
                });
                
            }
        }
    }
}
