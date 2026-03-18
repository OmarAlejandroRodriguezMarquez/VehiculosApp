using Microsoft.EntityFrameworkCore;
using VehiculosAPI.Data;
using VehiculosAPI.Entities;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Services
{
    public class VehiculoService : IVehiculoService
    {
        private readonly ApplicationDbContext dbContext;

        public VehiculoService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Vehiculo> ActualizarVehiculoAsync(Vehiculo vehiculo)
        {
            var vehiculoExistente = await dbContext.Vehiculos.FindAsync(vehiculo.Id);
            vehiculoExistente.Modelo = "Vehículo editado";
            dbContext.Vehiculos.Update(vehiculoExistente);
            var vehiculoEditado = await dbContext.SaveChangesAsync();
            return vehiculoEditado > 0 ? vehiculoExistente : null;
        }

        public async Task<bool> EliminarVehiculoAsync(Vehiculo vehiculo)
        {
            var vehiculoExistente = await dbContext.Vehiculos.FindAsync(vehiculo.Id);
            dbContext.Vehiculos.Remove(vehiculoExistente);
            var resultadoEliminacion = await dbContext.SaveChangesAsync();
            return resultadoEliminacion > 0;
        }

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

        public async Task<List<Vehiculo>> GetAllVehiculosFromDBAsync()
        {
            return await dbContext.Vehiculos.ToListAsync();
        }

        public async Task<CatMarca> RegistrarMarcaAsync(CatMarca marca)
        {
            await dbContext.AddAsync(marca);
            var nuevaMarcaGuardada = await dbContext.SaveChangesAsync();
            return nuevaMarcaGuardada > 0 ? marca : null;
        }

        public async Task<Vehiculo> RegistrarVehiculoAsync(Vehiculo vehiculo)
        {
            await dbContext.AddAsync(vehiculo);
            var nuevoVehiculoGuardado = await dbContext.SaveChangesAsync();
            return nuevoVehiculoGuardado > 0 ? vehiculo : null;
        }
    }
}
