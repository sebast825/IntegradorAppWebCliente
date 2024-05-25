using Integrador.Dal.Entities;

namespace Integrador.Dal.Repository.Interface
{
    public interface IViajeRepositorio : IRepository<Viaje>
    {
        Task<List<Viaje>> GetByDominio(string dominio);
    }
}
