using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Db;
using OnlineShop.Db.BDModels;
using OnlineShopWebApp.Areas.Account.Models;
using Serilog;
using System;

namespace OnlineShopWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       
        public void ConfigureServices(IServiceCollection services)
        {
            //�������� ������ ������������ �� appsettings
            string connection = Configuration.GetConnectionString("online_shop");
            //�������� �������� DatabaseContext � �������� ������� � ����������
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));
            //�������� �������� IdentityContext � �������� ������� � ����������
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityContext>();//��������������� ��� ��������� ������

            services.AddTransient<EmailService>();
            services.AddTransient<IFavoritesStorage, FavoritesDbStorage>();
            services.AddTransient<IComparingStorage, ComparingDbStorage>();
            services.AddTransient<IOrdersStorage, OrdersDbStorage>();
            services.AddTransient<IProductsStorage, ProductsDbStorage>();
            services.AddSingleton<IRolesStorage, RolesInMemoryStorage>();
            services.AddTransient<ICartsStorage, CartsDbStorage>();
            services.AddControllersWithViews();

            services.ConfigureApplicationCookie(options =>
           {
               options.ExpireTimeSpan = TimeSpan.FromHours(8);
               options.LoginPath = "/Account/Account/Login";
               options.LogoutPath = "/Account/Account/Logout";
               options.Cookie = new CookieBuilder
               {
                   IsEssential = true
               };
           });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          //����� ������ �������� ��������� ������ ��������

            app.UseStaticFiles();

            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
