using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Core.Contracts;
using OnlineFurnitureShop.Core.Services;
using OnlineFurnitureShop.Data;
using OnlineFurnitureShop.Infrastructure.Data.Common;
using OnlineFurnitureShop.Infrastructure.Data.Models;

namespace OnlineFurnitureShop.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAppService(this IServiceCollection services)
        {
            services.AddScoped<IFurnitureService, FurnitureService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IItemService, ItemService>();

            return services;
        }

        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<OnlineFurnitureShopDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddAppIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<OnlineFurnitureShopDbContext>();

            return services;
        }
    }
}
