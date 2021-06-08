using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjMvcApp.Data;

[assembly: HostingStartup(typeof(ProjMvcApp.Areas.Identity.IdentityHostingStartup))]
namespace ProjMvcApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjMvcAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjMvcAppContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ProjMvcAppContext>();
            });
        }
    }
}