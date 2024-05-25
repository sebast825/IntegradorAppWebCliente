using AutoMapper;
using Azure;
using Integrador.Dal;
using Integrador.Dal.Entities;
using Integrador.Dto.Viajes;
using Integrador.Service.Interface;

namespace Integrador.Service
{
    public class ViajeService : IViajeService
    {

        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
        public ViajeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ViajeReponseDTO> Create(ViajeCreateRequestDTO dto)
        {
            /*
            if (_mapper == null)
            {
                throw new InvalidOperationException("Mapper no está inicializado.");
            }
            var viajeEntity = _mapper.Map<Viaje>(dto);

            await _unitOfWork.ViajeRepository.Add(viajeEntity);
                        var result = _mapper.Map<ViajeReponseDTO>(dto);

            */
            ViajeReponseDTO response = new ViajeReponseDTO();
            return await Task.FromResult(response);
        }

        public async Task<List<ViajeReponseDTO>> GetAll()
        {
            var viajes = await _unitOfWork.ViajeRepository.GetAll();
            return null;

                }

        public async Task<List<ViajeReponseDTO>> GetByDomimnio(string dominio)
        {
            var viaje = await _unitOfWork.ViajeRepository.GetByDominio(dominio);
            return null;
        }

      
    }
}
