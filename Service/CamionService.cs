using AutoMapper;
using Azure;
using Integrador.Dal;
using Integrador.Dal.Entities;
using Integrador.Dto.Camion;
using Integrador.Service.Interface;
using System.Linq.Expressions;

namespace Integrador.Service
{
    public class CamionService : ICamionService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CamionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

        public async Task<CamionReponseDTO> GetByDomimnio(string dominio)
        {
            var camion = await _unitOfWork.CamionRepository.GetByDominio(dominio);
           //var result = _mapper.Map<List<CamionReponseDTO>>(camion);

            var camionList = new List<CamionReponseDTO>();
            
                var responseDto = new CamionReponseDTO
                {
                    MarcaModelo = camion.Marca + " " + camion.Modelo,
                    Conductor = camion.Conductor,
                    Dominio = camion.Dominio,
                    CantidadDeViajes = camion.Viajes.Count().ToString(),
                    NumeroChasis = camion.NumeroChasis,
                    NumeroMotor = camion.NumeroMotor,
                    Anio = camion.Anio


                };
                return responseDto;

                //Console.WriteLine(camion);


            
        }

      
    }
}
