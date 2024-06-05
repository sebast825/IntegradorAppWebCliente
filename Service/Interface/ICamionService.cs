using Integrador.Dal.Entities;
using Integrador.Dto.Camion;
using System.Collections.Specialized;

namespace Integrador.Service.Interface
{
    public interface ICamionService
    {
        Task<List<CamionReponseDTO>> GetAll();
        Task<CamionReponseDTO> GetByDomimnio(string dominio);
        Task<CamionReponseDTO> Create(CamionCreateRequestDTO dto);

        Task<CamionReponseDTO> Update(string dominio, CamionUpdateRequestDTO updateRequest);

    }
}
