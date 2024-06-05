using Integrador.Dal.Repository.Interface;
using Integrador.Dto.Camion;
using Integrador.Dto.Viajes;
using Integrador.Service;
using Integrador.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamionController : ControllerBase
    {
        private readonly ICamionService _camionService;
        public CamionController(ICamionService camionService)
        {
            _camionService = camionService;
        }

        [HttpGet("GetByDomimnio")]
        public async Task<ActionResult<ViajeReponseDTO>> GetByDomimnio(string dominio)
        {
            var viaje = await _camionService.GetByDomimnio(dominio);
            return Ok(viaje);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<ViajeReponseDTO>>> GetAll()
        {
            var viaje = await _camionService.GetAll();
            return Ok(viaje);
        }
        [HttpPost("Create")]
        public async Task<ActionResult<bool>> Create(CamionCreateRequestDTO camion)
        {
            var respuesta = await _camionService.Create(camion);
            return respuesta != null ? Ok(respuesta) : BadRequest("No se pudo ejercutar correctamente");
        }
    }
}
