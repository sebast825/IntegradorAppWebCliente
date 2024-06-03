using Integrador.Dal.Data;
using Integrador.Dal.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Dal.Repository
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected readonly DataContext _context;

        public Repository (DataContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            /*estyos son metodos del data context
             nos permite agregar el dato a la db,
            dataContext trae las tablas existentes de la db
            y con el metodo addAsync lo agregua
             */
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);  
        }

        public async Task<List<T>> GetAll()
        {

            /*toListAsync una vez que termina cierra la peticion con la db*/
            return await _context.Set<T>().ToListAsync();        }

        public async Task<T> GetId(int id)
        {
            return await _context.Set<T>().FindAsync(id);
                }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
                }
    }
}
