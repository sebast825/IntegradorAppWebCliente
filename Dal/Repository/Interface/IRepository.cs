namespace Integrador.Dal.Repository.Interface
{
    /*T es una clase*/
    public interface IRepository<T> where T : class
    {
        /*T ->dato generico*/
        Task<List<T>> GetAll();
        Task<T> GetId(int id);
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
