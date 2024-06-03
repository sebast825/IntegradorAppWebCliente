using Integrador.Dal.Entities;
using Integrador.Dto.Camion;

namespace Integrador.Service.Interface
{
    public interface ICamionService
    {
        Task<List<CamionReponseDTO>> GetAll();
        Task<List<CamionReponseDTO>> GetByDomimnio(string dominio);
        Task<CamionReponseDTO> Create(CamionCreateRequestDTO dto);


    }
}
