using BlogifyHub.Web.IServices;
using BlogifyHub.Web.Providers;
using BlogifyHub.Web.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.ComponentModel.Design;

namespace BlogifyHub.Web.Extensions
{
    public static class ConfigApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<ILocalStorageService, LocalStorageService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ApiAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<ApiAuthenticationStateProvider>());
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7060/") });
            return services;
        }
    }
}
