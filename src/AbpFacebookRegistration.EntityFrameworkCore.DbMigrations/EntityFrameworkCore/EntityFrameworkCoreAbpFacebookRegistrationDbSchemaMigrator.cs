using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpFacebookRegistration.Data;
using Volo.Abp.DependencyInjection;

namespace AbpFacebookRegistration.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpFacebookRegistrationDbSchemaMigrator
        : IAbpFacebookRegistrationDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpFacebookRegistrationDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpFacebookRegistrationMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpFacebookRegistrationMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}