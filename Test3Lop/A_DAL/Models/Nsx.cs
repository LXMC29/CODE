using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class Nsx
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<ChiTietSp> ChiTietSps { get; } = new List<ChiTietSp>();
}
