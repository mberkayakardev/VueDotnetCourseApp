using ApiService.Entities.Concrete.AppEntities;
using Core.Repositories.EntityFramework.Concrete;
using Microsoft.EntityFrameworkCore;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Repositories.EntityFramework.Concrete.Contexts;
using System.Linq.Expressions;

namespace QuizApp.Repositories.EntityFramework.Concrete.Repositories
{
    public class EfAppUserRepositories : EfGenericRepositories<AppUser>, IAppUserRepositories
    {
        public EfAppUserRepositories(AppDbContext context) : base(context)
        {

        }

        public async Task<AppUser> GetUserByIdIdentityInformation(Expression<Func<AppUser,bool>> where)
        {
            var dbcontext = _Context as AppDbContext;

            var query = dbcontext.AppUsers
                    .Include(u => u.AppUserRoles)
                        .ThenInclude(ur => ur.Role)
                            .ThenInclude(r => r.AppRoleClaims)
                                .ThenInclude(rc => rc.AppClaims)
                    .Include(u => u.AppUserClaims)
                        .ThenInclude(uc => uc.AppClaim)
                    .Include(u => u.UserToken);


                return await query.FirstOrDefaultAsync(where);

        }
    }
}
