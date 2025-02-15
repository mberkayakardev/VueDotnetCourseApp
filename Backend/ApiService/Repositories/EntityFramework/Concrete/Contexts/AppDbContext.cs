using ApiService.Entities.Concrete.AppEntities;
using Core.Entities.Abstract;
using Core.Entities.Concrete.AppEntities;
using Entities.Concrete.AppEntities;
using Entities.Concrete.Courses;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace QuizApp.Repositories.EntityFramework.Concrete.Contexts
{
    public class AppDbContext : DbContext
    {
        private bool _auditingRulesApplied = false;
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) 
        {
            
        }

        #region DbSets
        public DbSet<AppApplications> AppApplications { get; set; }
        public DbSet<AppClaim> AppClaims { get; set; }  
        public DbSet<AppMenus> AppMenus { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppRoleClaim> AppRoleClaims { get; set; }
        public DbSet<AppToken> AppTokens { get; set; }  
        public DbSet<AppUser> AppUsers { get; set; }    
        public DbSet<AppUserClaims> AppUserClaims { get; set; }
        public DbSet<AppUserRoles> AppUserRoles { get; set; }

        public DbSet<Courses> Courses { get; set; } 
        #endregion
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            if (!_auditingRulesApplied)
            {
                ApplyAuditingRules();
                _auditingRulesApplied = true;
            }
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            if (!_auditingRulesApplied)
            {
                ApplyAuditingRules();
                _auditingRulesApplied = true;
            }
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        }


        private void ApplyAuditingRules()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.ModifiedDate = DateTime.Now;

                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedDate").IsModified = false;
                    entry.Entity.ModifiedDate = DateTime.Now;
                }
            }
        }

    }
}
