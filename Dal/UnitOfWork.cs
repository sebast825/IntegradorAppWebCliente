using Integrador.Dal.Data;
using Integrador.Dal.Repository.Interface;

namespace Integrador.Dal
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICamionRepository CamionRepository { get; }

        public IViajeRepositorio ViajeRepository  {get;}

        private readonly DataContext _context;
        public UnitOfWork(DataContext context, ICamionRepository camionRepository, IViajeRepositorio viajeRepository) {
            _context = context;
            CamionRepository = camionRepository;
            ViajeRepository = viajeRepository;

        }

        public void Dispose()
        {
            _context?.Dispose();
         }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();        }
    }
}
