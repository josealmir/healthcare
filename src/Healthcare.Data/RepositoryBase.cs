using Healthcare.Domain;

namespace Healthcare.Data
{
    public abstract class RepositoryBase<T> : IRepository<T> where T: Entity
    {
        protected readonly AppDbContext _dbContext;

        protected RepositoryBase(AppDbContext dbContext)
            => _dbContext = dbContext;

        public void Add(T entity)
            => _dbContext.Add(entity);
    }
}
