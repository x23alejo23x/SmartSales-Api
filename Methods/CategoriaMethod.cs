using Microsoft.EntityFrameworkCore;
using SmartSales_Api.Context;
using SmartSales_Api.Models.Dtos;

namespace SmartSales_Api.Events
{
    public class CategoriaMethod : ICategoria
    {
        private readonly AppDbContext _context;

        public CategoriaMethod(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Categoria>> GetAllAsync() =>
            await _context.Categorias.OrderBy(c => c.Id)
            .ToListAsync();
    }
}
