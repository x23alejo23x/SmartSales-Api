using System;
using System.Collections.Generic;

namespace SmartSales_Api.Models.Dtos;

public partial class Producto
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public long CategoriaId { get; set; }

    public string? ImagenUrl { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<Promocione> Promociones { get; set; } = new List<Promocione>();
}
