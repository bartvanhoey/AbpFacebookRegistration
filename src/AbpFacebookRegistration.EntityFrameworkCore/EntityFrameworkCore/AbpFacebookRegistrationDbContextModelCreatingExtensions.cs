using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpFacebookRegistration.EntityFrameworkCore
{
    public static class AbpFacebookRegistrationDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpFacebookRegistration(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpFacebookRegistrationConsts.DbTablePrefix + "YourEntities", AbpFacebookRegistrationConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}