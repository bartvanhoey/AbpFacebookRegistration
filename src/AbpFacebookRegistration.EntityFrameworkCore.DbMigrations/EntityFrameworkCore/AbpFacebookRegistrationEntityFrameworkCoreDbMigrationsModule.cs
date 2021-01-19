using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpFacebookRegistration.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpFacebookRegistrationEntityFrameworkCoreModule)
        )]
    public class AbpFacebookRegistrationEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpFacebookRegistrationMigrationsDbContext>();
        }
    }
}
