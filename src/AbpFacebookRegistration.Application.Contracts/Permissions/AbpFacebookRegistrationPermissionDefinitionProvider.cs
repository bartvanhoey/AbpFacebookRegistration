using AbpFacebookRegistration.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpFacebookRegistration.Permissions
{
    public class AbpFacebookRegistrationPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpFacebookRegistrationPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpFacebookRegistrationPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpFacebookRegistrationResource>(name);
        }
    }
}
