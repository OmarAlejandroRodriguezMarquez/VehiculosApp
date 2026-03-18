using Microsoft.AspNetCore.Mvc;
using VehiculosAPI.Entities;
using VehiculosAPI.Services;

namespace VehiculosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService vehiculoService;

        public VehiculoController(IVehiculoService vehiculoService)
        {
            this.vehiculoService = vehiculoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehiculo>>> GetAllVehiculos()
        {
            var vehiculos = await vehiculoService.GetAllVehiculosAsync();
            //var vehiculos = new List<Vehiculo>();

            if (vehiculos.Count == 0)
            {
                return NoContent();
            }

            return Ok(vehiculos);
        }
    }
}
