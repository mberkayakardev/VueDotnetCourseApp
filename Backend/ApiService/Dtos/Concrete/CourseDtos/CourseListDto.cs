using Core.Dtos.Abstract;

namespace Dtos.Concrete.CourseDtos
{
    public class CourseListDto : BaseDtos
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal CoursePrice { get; set; }
        public string CourseCoverImage { get; set; }

    }
}
