using Healthcare.Domain.Infra;

namespace Healthcare.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
            => _dbContext = dbContext;

        public async Task<bool> SaveChangeAsync()
            => await _dbContext.SaveChangesAsync() > 0;
        
        public bool SaveChange()
            => _dbContext.SaveChanges() > 0;
    }
}
