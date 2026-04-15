using VehiculosAPI.Data;
using VehiculosAPI.DTOs;
using VehiculosAPI.Entities.Catalogos;
using Microsoft.EntityFrameworkCore;

namespace VehiculosAPI.Services
{
    public class CatMarcaService : ICatMarcaService
    {
        private readonly ApplicationDbContext dbContext;

        public CatMarcaService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> CreateAsync(CrearCatMarcaDTO crearCatMarcaDTO)
        {
            CatMarca nuevaMarca = new CatMarca
            {
                Marca = crearCatMarcaDTO.Marca
            };

            dbContext.CatMarcas.Add(nuevaMarca);
            var result = await dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return nuevaMarca.Id;
            }
            else
            {
                throw new Exception("No se pudo crear la marca.");
            }
        }

        public async Task<List<MarcaDTO>> GetAsync()
        {
            return await dbContext.CatMarcas.Select(m => new MarcaDTO { Marca = m.Marca }).ToListAsync();
        }
    }
}
