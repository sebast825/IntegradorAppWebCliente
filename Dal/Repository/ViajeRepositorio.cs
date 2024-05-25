using Integrador.Dal.Data;
using Integrador.Dal.Entities;
using Integrador.Dal.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Dal.Repository
{
    public class ViajeRepositorio : Repository<Viaje>, IViajeRepositorio
    {
        public ViajeRepositorio(DataContext context) : base(context)
        {
        }

        public async Task<List<Viaje>> GetByDominio(string dominio)
        {
            var viaje = await _context.Viajes.Include(x => x.Camion).Where(x => x.Camion.Dominio == dominio).ToListAsync();
            return viaje;
        
        }
    }
}
