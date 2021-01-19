using Volo.Abp.Settings;

namespace AbpFacebookRegistration.Settings
{
    public class AbpFacebookRegistrationSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpFacebookRegistrationSettings.MySetting1));
        }
    }
}
