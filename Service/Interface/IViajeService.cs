using Integrador.Dal.Entities;
using Integrador.Dto.Viajes;

namespace Integrador.Service.Interface
{
    public interface IViajeService
    {
        Task<List<ViajeReponseDTO>> GetAll();
        Task<List<ViajeReponseDTO>> GetByDomimnio(string dominio);
        Task<ViajeReponseDTO> Create(ViajeCreateRequestDTO dto);


    }
}
