using System;
using System.Collections.Generic;

namespace SmartSales_Api.Models.Dtos;

public partial class Categoria
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
