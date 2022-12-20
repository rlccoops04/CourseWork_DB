using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Deal
{
    public int KodDeal { get; set; }

    public DateTime DataDeal { get; set; }

    public string? KadastrNom { get; set; }

    public int IdBuyer { get; set; }

    public int IdSpec { get; set; }

    public virtual Buyer IdBuyerNavigation { get; set; } = null!;

    public virtual Specialist IdSpecNavigation { get; set; } = null!;

    public virtual Apartment? KadastrNomNavigation { get; set; }
}
