    using Microsoft.AspNetCore.Mvc;
    using SmartSales_Api.Events;

    namespace SmartSales_Api.Controllers
    {
        [ApiController]
        [Route("")]
        [Tags("Métodos Get")]
        public class CategoriaController : ControllerBase
        {
            private readonly ICategoria _categoria;

            public CategoriaController(ICategoria categoria) => _categoria = categoria;

            /// <summary>
            /// Endpoint para obtener todas las categorías
            /// </summary>
            [HttpGet("categorias")]
            [EndpointSummary("|| Retorna Categorias")]
        public Task<IResult> GetCategorias() => MethodGeneric.HandleSPRequest(_categoria.GetAllAsync);
        }
    }
