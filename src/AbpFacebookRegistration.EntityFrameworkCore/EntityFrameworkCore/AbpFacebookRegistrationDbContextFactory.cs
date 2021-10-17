using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpFacebookRegistration.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpFacebookRegistrationDbContextFactory : IDesignTimeDbContextFactory<AbpFacebookRegistrationDbContext>
    {
        public AbpFacebookRegistrationDbContext CreateDbContext(string[] args)
        {
            AbpFacebookRegistrationEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpFacebookRegistrationDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpFacebookRegistrationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpFacebookRegistration.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
