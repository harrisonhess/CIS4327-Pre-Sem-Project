using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project_0.Areas.Identity.Data;
using Project_0.Data;

[assembly: HostingStartup(typeof(Project_0.Areas.Identity.IdentityHostingStartup))]
namespace Project_0.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VMSDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VMSDbContextConnection")));

                services.AddDefaultIdentity<VMSUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VMSDbContext>();
            });
        }
    }
}