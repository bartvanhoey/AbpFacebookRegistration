using System.Threading.Tasks;

namespace AbpFacebookRegistration.Data
{
    public interface IAbpFacebookRegistrationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
