using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Adre
{
    public int IdAdres { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string HomeNom { get; set; } = null!;

    public string ApartNom { get; set; } = null!;

    public string Metro { get; set; } = null!;

    public virtual ICollection<Apartment> Apartments { get; } = new List<Apartment>();
}
