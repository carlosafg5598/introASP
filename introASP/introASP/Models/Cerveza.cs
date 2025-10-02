using System;
using System.Collections.Generic;

namespace introASP.Models;

public partial class Cerveza
{
    public int IdCerveza { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdBrand { get; set; }

    public virtual Brand IdBrandNavigation { get; set; } = null!;
}
