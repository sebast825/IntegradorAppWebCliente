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
            var camiones = await _unitOfWork.CamionRepository.GetAllFull();
            // Check if camiones is a single Camion object
            throw new InvalidOperationException("Unexpected type returned from repository");

            if (camiones.Count() == 1)
            {
                return new List<CamionReponseDTO> { EntityToCamionResponseDto(camiones[0]) };
            }
            // Check if camiones is a collection
            else if (camiones is IEnumerable<Camion> camionCollection)
            {
            
                return EntitiesToCamionResponseDtos(camionCollection);
            }
            else
            {
                throw new InvalidOperationException("Unexpected type returned from repository");
            }
          

                }

        public async Task<CamionReponseDTO> GetByDomimnio(string dominio)
        {
            var camion = await _unitOfWork.CamionRepository.GetByDominio(dominio);
            //var result = _mapper.Map<List<CamionReponseDTO>>(camion);


            return EntityToCamionResponseDto(camion);

                //Console.WriteLine(camion);
            
        }
        public List<CamionReponseDTO> EntitiesToCamionResponseDtos(IEnumerable<Camion> camiones)
        {
            var responseDtos = new List<CamionReponseDTO>();
            foreach (Camion camion in camiones)
            {
                responseDtos.Add(EntityToCamionResponseDto(camion));
            }
            return responseDtos;
        }
        public CamionReponseDTO EntityToCamionResponseDto(Camion camion)
        {
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
        }



    }
}
