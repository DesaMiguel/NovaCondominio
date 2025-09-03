﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models;

public partial class Anticipo
{
    public int IdAnticipo { get; set; }

    public int Numero { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Saldo { get; set; }

    public string Detalle { get; set; } = string.Empty;

    public int IdProveedor { get; set; }

    public bool Activo { get; set; }

    public int IdCodCuenta { get; set; }

    public decimal? MontoUtilizado { get; set; }

    public virtual CodigoCuentasGlobal IdCodCuentaNavigation { get; set; } = null!;

    [Display(Name = "Proveedor")]

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual ICollection<PagoAnticipo> PagoAnticipos { get; set; } = new List<PagoAnticipo>();

    public virtual ICollection<PagoFactura> PagoFacturas { get; set; } = new List<PagoFactura>();
}
