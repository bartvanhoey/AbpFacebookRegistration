using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpFacebookRegistration.Data
{
    /* This is used if database provider does't define
     * IAbpFacebookRegistrationDbSchemaMigrator implementation.
     */
    public class NullAbpFacebookRegistrationDbSchemaMigrator : IAbpFacebookRegistrationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}