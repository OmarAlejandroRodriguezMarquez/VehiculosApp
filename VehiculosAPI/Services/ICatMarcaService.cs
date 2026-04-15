using VehiculosAPI.DTOs;
using VehiculosAPI.Entities.Catalogos;

namespace VehiculosAPI.Services
{
    public interface ICatMarcaService
    {
        Task<int> CreateAsync(CrearCatMarcaDTO crearCatMarcaDTO);
        Task<List<MarcaDTO>> GetAsync();
    }
}
