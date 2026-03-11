using Microsoft.EntityFrameworkCore;

namespace MGP.Infra
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public void RemoveEntityContext<TEntity>(TEntity entity) where TEntity : class
        {
            if (entity is not null)
                Set<TEntity>().Remove(entity);
        }


    }
}
