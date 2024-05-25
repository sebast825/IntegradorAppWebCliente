using Integrador.Dal.Entities;
using Integrador.Dto.Viajes;
using Integrador.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Integrador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
        private readonly IViajeService _viajeService;

        public ViajeController(IViajeService viajeService)
        {
            _viajeService = viajeService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<ViajeReponseDTO>>> GetAll()
        {
             await _viajeService.GetAll();
            return Ok();
        }

        [HttpGet("GetByDomimnio")]
        public async Task<ActionResult<List<ViajeReponseDTO>>> GetByDomimnio(string dominio)
        {
            await _viajeService.GetByDomimnio(dominio);
            return Ok();
        }

        [HttpPost("Create")]
        public async Task<ActionResult<bool>> Create(ViajeCreateRequestDTO viaje)
        {

            var respuesta = await _viajeService.Create(viaje);
            return Ok(respuesta);
        }
    }
}
