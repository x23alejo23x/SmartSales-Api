using System;
using System.Collections.Generic;

namespace SmartSales_Api.Models;

public partial class Usuario
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public long IdRol { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual Role IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Promocione> Promociones { get; set; } = new List<Promocione>();
}
