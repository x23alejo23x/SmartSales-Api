using System;
using System.Collections.Generic;

namespace SmartSales_Api.Models;

public partial class Promocione
{
    public long Id { get; set; }

    public long IdProducto { get; set; }

    public decimal PrecioOriginal { get; set; }

    public decimal PrecioPromocion { get; set; }

    public string Fuente { get; set; } = null!;

    public string UrlProducto { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public long IdUsuarioRegistro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioRegistroNavigation { get; set; } = null!;
}
