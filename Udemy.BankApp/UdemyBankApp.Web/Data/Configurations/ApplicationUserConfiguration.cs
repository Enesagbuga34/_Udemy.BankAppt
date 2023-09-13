using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyBankApp.Web.Data.Entities;

namespace UdemyBankApp.Web.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(200); 
            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(250);
            builder.Property(x => x.Surname).IsRequired();

            builder.HasMany(x => x.Accounts).WithOne(x => x.ApplicationUser).HasForeignKey(x => x.ApplicationUserId);
        }
    }
}
