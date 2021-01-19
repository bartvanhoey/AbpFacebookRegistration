using System;
using System.Collections.Generic;
using System.Text;
using AbpFacebookRegistration.Localization;
using Volo.Abp.Application.Services;

namespace AbpFacebookRegistration
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpFacebookRegistrationAppService : ApplicationService
    {
        protected AbpFacebookRegistrationAppService()
        {
            LocalizationResource = typeof(AbpFacebookRegistrationResource);
        }
    }
}
