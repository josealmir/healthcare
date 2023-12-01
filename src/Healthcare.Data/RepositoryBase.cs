using Healthcare.Domain;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Data
{
    public abstract class RepositoryBase<T> : IRepository<T> where T: Entity
    {
        protected readonly AppDbContext _dbContext;

        protected RepositoryBase(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
            => _dbContext.Set<T>().Add(entity);

        public void Remove(T entity)
            => _dbContext.Set<T>().Remove(entity);

        public void Update(T entity)
            => _dbContext.Set<T>().Update(entity);

        public async Task<T> FindByIdAsync(long id,  CancellationToken cancellationToken)
            => await _dbContext.Set<T>().SingleAsync(x => x.Id == id, cancellationToken);
    }
}
