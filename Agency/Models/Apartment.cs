using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Apartment
{
    public string KadastrNom { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public double LiveSpace { get; set; }

    public double GeneralSpace { get; set; }

    public int CountRooms { get; set; }

    public int NumFloor { get; set; }

    public string TypeBuild { get; set; } = null!;

    public int YearBuild { get; set; }

    public string? Metro { get; set; }

    public string? Furniture { get; set; }

    public decimal Price { get; set; }

    public string LoginOwner { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();

    public virtual Owner LoginOwnerNavigation { get; set; } = null!;
}
