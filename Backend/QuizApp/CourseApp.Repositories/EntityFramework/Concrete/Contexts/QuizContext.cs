using Microsoft.EntityFrameworkCore;
using QuizApp.Entities.Concrete.AppEntities;
using System.Reflection;

namespace QuizApp.Repositories.EntityFramework.Concrete.Contexts
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> opt) : base(opt) 
        {
            
        }

        #region DbSets
        public DbSet<AppUser> AppUsers { get; set; }
        #endregion
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
