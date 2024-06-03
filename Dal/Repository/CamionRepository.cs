using Integrador.Dal.Data;
using Integrador.Dal.Entities;
using Integrador.Dal.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Dal.Repository
{
    public class CamionRepository : Repository<Camion>, ICamionRepository
    {
        public CamionRepository(DataContext context) : base(context)
        {
        }

        public async Task<Camion> GetByDominio(string dominio)
        {
            /*para cada camion trae todos los viajes que tiene*/
            var camion = _context.Camiones
                .Include(c => c.Viajes)
                .Where(x=>x.Dominio == dominio).FirstOrDefault();
            return camion;
                }
    }
}
