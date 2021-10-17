using AbpFacebookRegistration.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpFacebookRegistration.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpFacebookRegistrationEntityFrameworkCoreModule),
        typeof(AbpFacebookRegistrationApplicationContractsModule)
        )]
    public class AbpFacebookRegistrationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
