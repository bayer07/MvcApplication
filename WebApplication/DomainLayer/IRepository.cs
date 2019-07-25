namespace WebApplication.Interfaces
{
    public interface IRepository<E, T> where E : IEntity<T>
    {
        T Create(E entity);
    }
}
