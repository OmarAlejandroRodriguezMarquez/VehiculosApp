using System.Data.Common;
using VehiculosAPI.Entities;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Services
{
    public interface IVehiculoService
    {
        Task<List<Vehiculo>> GetAllVehiculosAsync();
        Task<CatMarca> RegistrarMarcaAsync(CatMarca marca);
        Task<Vehiculo> RegistrarVehiculoAsync(Vehiculo vehiculo);

        //Nuevas funciones
        Task<List<Vehiculo>> GetAllVehiculosFromDBAsync();
        Task<Vehiculo> ActualizarVehiculoAsync(Vehiculo vehiculo);
        Task<bool> EliminarVehiculoAsync(Vehiculo vehiculo);
    }
}
