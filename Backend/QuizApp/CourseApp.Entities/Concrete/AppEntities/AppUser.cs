
using Core.Entities.Abstract;

namespace QuizApp.Entities.Concrete.AppEntities
{
    public class AppUser : BaseEntity
    {
        public string UserFullName { get; set; }
        public string UserName {  get; set; }
        public string NormalizedUserName {  get; set; }
        public string UserEmail { get; set; }
        public string NormalizedUserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool IsBlocked { get; set; }
        public int FalseEntryCount { get; set; }

        
    }
}
