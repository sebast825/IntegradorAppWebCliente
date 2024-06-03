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
            var viajes =  await _viajeService.GetAll();
            return Ok(viajes);
        }

        [HttpGet("GetByDomimnio")]
        public async Task<ActionResult<List<ViajeReponseDTO>>> GetByDomimnio(string dominio)
        {
            var viaje = await _viajeService.GetByDomimnio(dominio);
            return Ok(viaje);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<bool>> Create(ViajeCreateRequestDTO viaje)
        {

            var respuesta = await _viajeService.Create(viaje);
            return Ok(respuesta);
        }
    }
}
