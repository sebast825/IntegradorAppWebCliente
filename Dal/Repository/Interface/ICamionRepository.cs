using Integrador.Dal.Entities;

namespace Integrador.Dal.Repository.Interface
{
    public interface ICamionRepository : IRepository<Camion>

    {
        Task<Camion> GetByDominio(string dominio);
    }
}
