using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpFacebookRegistration.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpFacebookRegistrationBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpFacebookRegistration";
    }
}
