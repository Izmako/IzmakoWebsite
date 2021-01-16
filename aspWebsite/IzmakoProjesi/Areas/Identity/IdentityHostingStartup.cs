using System;
using IzmakoProjesi.Areas.Identity.Data;
using IzmakoProjesi.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IzmakoProjesi.Areas.Identity.IdentityHostingStartup))]
namespace IzmakoProjesi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDb>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppDbConnection")));

                services.AddDefaultIdentity<IzmakoProjesiUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AppDb>();
            });
        }
    }
}