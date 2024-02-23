using AutoMapper;
using BlogifyHub.API.Helpers;
using BlogifyHub.API.Middleware;
using BlogifyHub.Repository.Interface;
using BlogifyHub.Repository.Service;
using BlogifyHub.Service.IServices;
using BlogifyHub.Service.Models;
using BlogifyHub.Service.Services;

namespace BlogifyHub.API.Extensions
{
    public static class ConfigApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITokenManagerService, TokenManagerService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddTransient<ExceptionHandlingMiddleware>();
            services.AddTransient<ResponseDto>();

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(typeof(MappingConfig));
            services.AddHttpContextAccessor();

            return services;
        }
    }
}
