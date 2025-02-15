using Entities.Concrete.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Repositories.EntityFramework.Concrete.Seeds.Course
{
    public class CourseSeeds : IEntityTypeConfiguration<Courses>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Courses> builder)
        {
            List<Courses> Kurslar = new List<Courses>
            {
                new Courses {Id = 1,CourseCoverImage = "https://berkayakar.com.tr/StaticFiles/ProfilFoto.jpg", CourseName = "C# Uygulama Geliştirme", CourseDescription = "C# ile uygulama geliştirme yapılacak", CoursePrice = 12, CreatedUserId = null, ModifiedDate = null,IsActive = true, ModifiedUserName = null,}

            };


            builder.HasData(Kurslar);

        }
    }
}
