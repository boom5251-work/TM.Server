using Microsoft.EntityFrameworkCore;

namespace TransportManagement.Server.DAL.Context
{
    /// <summary>
    /// Интерфейс контекста базы данных приложения.
    /// </summary>
    public interface IDatabaseContext
    {
        public void Dispose();

        public int SaveChanges();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}