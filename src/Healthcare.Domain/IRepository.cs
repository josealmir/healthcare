namespace Healthcare.Domain;

public interface IRepository<T> where T : Entity
{
    public void Add(T entity);
}
