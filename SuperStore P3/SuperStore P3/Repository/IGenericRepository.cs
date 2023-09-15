namespace EcoPower_Logistics.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetByID(int id);
        IEnumerable<T> GetAll();

        void Add(T entity);
        void addRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
