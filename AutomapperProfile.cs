using AutoMapper;
using Integrador.Dal;
using Integrador.Dal.Entities;
using Integrador.Dto.Camion;
using Integrador.Dto.Viajes;

namespace Integrador
{
    public class AutomapperProfile : Profile
    {

        // Constructor sin parámetros
        public AutomapperProfile()
        {
            // Este constructor sin parámetros es necesario para que AutoMapper pueda crear una instancia de AutomapperProfile
        }
        private readonly IUnitOfWork _unitOfWork;
        public AutomapperProfile(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            CreateMap<Viaje, ViajeReponseDTO>()
                .ForMember(dest => dest.Dominio, opt => opt.MapFrom(src => src.Camion.Dominio))
                .ForMember(dest => dest.Conductor, opt => opt.MapFrom(src => src.Camion.Conductor))
                .ForMember(dest => dest.FechaHoraSalida, opt => opt.MapFrom(src => src.FechaSalida.ToString("yyyy-MM-dd HH:mm:ss")))
                .ForMember(dest => dest.FechaHoraLlegada, opt => opt.MapFrom(src => src.FechaLLegada.ToString("yyyy-MM-dd HH:mm:ss")))
.ForMember(dest => dest.DuracionViaje, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal((src.FechaLLegada - src.FechaSalida).TotalHours), 2)));

            CreateMap<ViajeCreateRequestDTO, Viaje>()
                    .ForMember(dest => dest.Camion, opt => opt.MapFrom(src => _unitOfWork.CamionRepository.GetByDominio(src.Dominio)));

            CreateMap<Camion, CamionReponseDTO>()
              .ForMember(dest => dest.MarcaModelo, opt => opt.MapFrom(src => $"{src.Marca} {src.Modelo}"))
              .ForMember(dest => dest.CantidadDeViajes, opt => opt.MapFrom(src => src.Viajes.Count.ToString()));

        }


    }
}
