using Core.Repositories.EntityFramework.Abstract;
using QuizApp.Entities.Concrete.AppEntities;

namespace QuizApp.Repositories.EntityFramework.Abstract
{
    public interface IAppUserRepositories : IEfGenericRepositories<AppUser>
    {

    }
}
