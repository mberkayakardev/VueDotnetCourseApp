using ApiService.Entities.Concrete.AppEntities;
using Core.Repositories.EntityFramework.Abstract;
using System.Linq.Expressions;

namespace QuizApp.Repositories.EntityFramework.Abstract
{
    public interface IAppUserRepositories : IEfGenericRepositories<AppUser>
    {
        Task<AppUser> GetUserByIdIdentityInformation(Expression<Func<AppUser,bool>> where);
    }
}
