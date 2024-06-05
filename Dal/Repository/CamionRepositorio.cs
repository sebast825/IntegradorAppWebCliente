using Integrador.Dal.Data;
using Integrador.Dal.Entities;
using Integrador.Dal.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Integrador.Dal.Repository
{
    public class CamionRepositorio : Repository<Camion>, ICamionRepository
    {
        public CamionRepositorio(DataContext context) : base(context)
        {
        }

        public async Task<List<Camion>> GetAllFull()
        {
            //es necesario para que sincronice los datos de camion tambien, si no no los trae
            return await _context.Camiones.Include(v => v.Viajes).ToListAsync();
        }
        public async Task<Camion> GetByDominio(string dominio)
        {
            /*para cada camion trae todos los viajes que tiene*/
            /* Para cada camion trae todos los viajes que tiene */
            var camion = await _context.Camiones
                .Include(c => c.Viajes)
                .FirstOrDefaultAsync(x => x.Dominio == dominio); // Asegúrate de que sea una operación asincrónica
            
            return camion; // Retorna el camion encontrado
        }



      

    }
}
