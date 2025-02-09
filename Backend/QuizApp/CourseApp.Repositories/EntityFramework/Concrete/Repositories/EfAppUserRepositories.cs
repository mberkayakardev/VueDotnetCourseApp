using Core.Repositories.EntityFramework.Concrete;
using Microsoft.EntityFrameworkCore;
using QuizApp.Entities.Concrete.AppEntities;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Repositories.EntityFramework.Concrete.Contexts;

namespace QuizApp.Repositories.EntityFramework.Concrete.Repositories
{
    public class EfAppUserRepositories : EfGenericRepositories<AppUser>, IAppUserRepositories
    {
        public EfAppUserRepositories(QuizContext context) : base(context)
        {

        }
    }
}
