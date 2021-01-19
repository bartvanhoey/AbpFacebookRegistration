using Volo.Abp.Bundling;

namespace AbpFacebookRegistration.Blazor
{
    public class AbpFacebookRegistrationBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}