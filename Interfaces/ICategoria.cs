using SmartSales_Api.Models.Dtos;

namespace SmartSales_Api.Events
{
    public interface ICategoria
    {
        Task<IEnumerable<Categoria>> GetAllAsync();
    }
}
