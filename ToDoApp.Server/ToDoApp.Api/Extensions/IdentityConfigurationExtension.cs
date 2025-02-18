using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ToDoApp.Api.options;
using ToDoList.Infrastructure.Dal;
using ToDoList.Infrastructure.Dal.Entities;

namespace ToDoApp.Api.Extensions;

public static class IdentityConfigurationExtension
{
    public static void AddIdentityConfiguration(this IServiceCollection services)
    {
        services.AddAuthentication();

        services.AddIdentityCore<UserEntity>(options =>
            {
                options.User.RequireUniqueEmail = false;
            }).AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        services.AddOptions<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme)
            .Configure<IOptions<IdentityTokenOptions>>((options, tokenOptions) =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(tokenOptions.Value.ExpiresDays);
                options.ClaimsIssuer = options.ClaimsIssuer;
            });
        
        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireDigit = true;
        });
        services.AddIdentityApiEndpoints<UserEntity>();
        
    }
}