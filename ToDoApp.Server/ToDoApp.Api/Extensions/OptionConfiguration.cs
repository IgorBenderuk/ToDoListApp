using Microsoft.Extensions.Options;
using ToDoApp.Api.options;

namespace ToDoApp.Api.Extensions;

public static class OptionConfiguration
{
    public static void AddOptionConfiguration(this IServiceCollection services,IConfiguration configuration)
    {   
        services.Configure<IOptions<IdentityTokenOptions>>(configuration.GetSection("Token"));
    }
}