using System;
using System.Collections.Generic;

namespace IntroAsp.Models;

public partial class Brand
{
    public int IdBrand { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cerveza> Cervezas { get; set; } = new List<Cerveza>();
}
