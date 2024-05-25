using Integrador.Dal;
using Integrador.Dto.Viajes;
using Integrador.Service.Interface;

namespace Integrador.Service
{
    public class ViajeService : IViajeService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ViajeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<ViajeReponseDTO> Create(ViajeCreateRequestDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViajeReponseDTO>> GetAll()
        {
            var viajes = await _unitOfWork.ViajeRepository.GetAll();
            return null;

                }

        public Task<List<ViajeReponseDTO>> GetByDomimnio(string dominio)
        {
            throw new NotImplementedException();
        }
    }
}
