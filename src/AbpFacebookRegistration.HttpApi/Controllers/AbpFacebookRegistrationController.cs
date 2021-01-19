using AbpFacebookRegistration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpFacebookRegistration.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpFacebookRegistrationController : AbpController
    {
        protected AbpFacebookRegistrationController()
        {
            LocalizationResource = typeof(AbpFacebookRegistrationResource);
        }
    }
}