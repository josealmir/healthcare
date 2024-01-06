namespace Healthcare.Domain.Infra
{
    public interface IUnitOfWork
    {
       public Task<bool> SaveChangeAsync();
        public bool SaveChange();
    }
}
