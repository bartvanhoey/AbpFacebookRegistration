using AbpFacebookRegistration.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpFacebookRegistration.Blazor
{
    public abstract class AbpFacebookRegistrationComponentBase : AbpComponentBase
    {
        protected AbpFacebookRegistrationComponentBase()
        {
            LocalizationResource = typeof(AbpFacebookRegistrationResource);
        }
    }
}
