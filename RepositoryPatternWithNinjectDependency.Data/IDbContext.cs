using System.Data.Entity;
using RepositoryPatternWithNinjectDependency.core;

namespace RepositoryPatternWithNinjectDependency.Data
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
