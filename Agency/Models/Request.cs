using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Request
{
    public int IdReq { get; set; }

    public DateTime DataReq { get; set; }

    public string KadastrNom { get; set; } = null!;

    public int IdBuyer { get; set; }

    public virtual Buyer IdBuyerNavigation { get; set; } = null!;

    public virtual Apartment KadastrNomNavigation { get; set; } = null!;
}
