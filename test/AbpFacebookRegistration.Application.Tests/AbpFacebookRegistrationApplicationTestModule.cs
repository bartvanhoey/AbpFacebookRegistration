using Volo.Abp.Modularity;

namespace AbpFacebookRegistration
{
    [DependsOn(
        typeof(AbpFacebookRegistrationApplicationModule),
        typeof(AbpFacebookRegistrationDomainTestModule)
        )]
    public class AbpFacebookRegistrationApplicationTestModule : AbpModule
    {

    }
}