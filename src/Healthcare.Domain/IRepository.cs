namespace Healthcare.Domain;

public interface IRepository<T> where T : Entity 
{
    public void Add(T entity);
    public void Update(T entity);
    public void Remove (T entity);
    public Task<T> FindByIdAsync(long id, CancellationToken cancellationToken);
}
