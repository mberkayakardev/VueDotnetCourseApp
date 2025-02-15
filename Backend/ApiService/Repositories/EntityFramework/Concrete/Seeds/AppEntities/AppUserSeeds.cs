
using ApiService.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrendMusic.ECommerce.Core.Utilities.Security.HashHelper;

namespace QuizApp.Repositories.EntityFramework.Concrete.EntityConfigurations.AppEntities
{
    public class AppUserSeeds : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    UserName = "berkayakar",
                    NormalizedUserName = "BERKAYAKAR",
                    UserEmail = "mberkayakar@gmail.com",
                    NormalizedUserEmail="MBERKAYAKAR@GMAIL.COM",
                    EmailConfirmed = true,
                    UserFullName = "Berkay Akar",
                    UserPassword = HashHelper.CreateSha256Hash("berkayakar"),
                    IsBlocked = false,
                    FalseEntryCount = 0,
                    IsActive = true,
                    CreatedDate = null,
                    ModifiedDate = null,
                    CreatedUserId = null,
                    ModifiedUserId = null,
                    CreatedUserName = "SEED DATA",
                    ModifiedUserName = "SEED DATA"
                }

                );
        }
    }
}
