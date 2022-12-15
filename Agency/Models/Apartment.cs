using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Apartment
{
    public string KadastrNom { get; set; } = null!;

    public int IdAdres { get; set; }

    public double LiveSpace { get; set; }

    public double GeneralSpace { get; set; }

    public int CountRooms { get; set; }

    public int NumFloor { get; set; }

    public string TypeBuild { get; set; } = null!;

    public int YearBuild { get; set; }

    public string Furniture { get; set; } = null!;

    public decimal Price { get; set; }

    public string LoginOwner { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();

    public virtual Adre IdAdresNavigation { get; set; } = null!;

    public virtual Owner LoginOwnerNavigation { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; } = new List<Request>();
}
