using Integrador.Dal.Repository.Interface;
using Integrador.Dto.Viajes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionController : ControllerBase
    {
        private readonly ICamionRepository _camionRepository;
        public CamionController( ICamionRepository camionRepository) {
            _camionRepository = camionRepository;
        }

        [HttpGet("GetByDomimnio")]
        public async Task<ActionResult<List<ViajeReponseDTO>>> GetByDomimnio(string dominio)
        {
            var viaje = await _camionRepository.GetByDominio(dominio);
            return Ok(viaje);
        }
    }
}
