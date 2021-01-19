using AbpFacebookRegistration.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpFacebookRegistration
{
    [DependsOn(
        typeof(AbpFacebookRegistrationEntityFrameworkCoreTestModule)
        )]
    public class AbpFacebookRegistrationDomainTestModule : AbpModule
    {

    }
}