using VehiculosAPI.Entities;

namespace VehiculosAPI.Services
{
    public class VehiculoService : IVehiculoService
    {
        public async Task<List<Vehiculo>> GetAllVehiculosAsync()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Vehiculo { Id = 1, MarcaId = 1, Modelo = "Corolla", Year = "2020", Placas="abc-123" },
                new Vehiculo { Id = 2, MarcaId = 2, Modelo = "Civic", Year = "2019", Placas="abc-456" },
                new Vehiculo { Id = 3, MarcaId = 3, Modelo = "Focus", Year = "2018", Placas="abc-789" }
            };
            return vehiculos;
        }
    }
}
