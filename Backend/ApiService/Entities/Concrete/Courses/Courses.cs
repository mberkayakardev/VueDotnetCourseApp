using Core.Entities.Abstract;

namespace Entities.Concrete.Courses
{
    public class Courses : BaseEntity
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public string CourseCoverImage { get; set; }
    }
}
