using AutoMapper;
using Azure;
using Integrador.Dal;
using Integrador.Dal.Entities;
using Integrador.Dto.Camion;
using Integrador.Service.Interface;

namespace Integrador.Service
{
    public class CamionService : ICamionService
    {

        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
        public CamionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CamionReponseDTO> Create(CamionCreateRequestDTO dto)
        {
            /*
            if (_mapper == null)
            {
                throw new InvalidOperationException("Mapper no está inicializado.");
            }
            var CamionEntity = _mapper.Map<Camion>(dto);

            await _unitOfWork.CamionRepository.Add(CamionEntity);
                        var result = _mapper.Map<CamionReponseDTO>(dto);

            */
            CamionReponseDTO response = new CamionReponseDTO();
            return await Task.FromResult(response);
        }

        public async Task<List<CamionReponseDTO>> GetAll()
        {
            var Camions = await _unitOfWork.CamionRepository.GetAll();
            return null;

                }

        public async Task<List<CamionReponseDTO>> GetByDomimnio(string dominio)
        {
            var camion = await _unitOfWork.CamionRepository.GetByDominio(dominio);
            Console.WriteLine(camion);
            return null;
        }

      
    }
}
