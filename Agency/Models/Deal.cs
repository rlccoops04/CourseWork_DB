using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Deal
{
    public int KodDeal { get; set; }

    public DateTime DataDeal { get; set; }

    public string LoginSpec { get; set; } = null!;

    public string? KadastrNom { get; set; }

    public string LoginBuyer { get; set; } = null!;

    public virtual Apartment? KadastrNomNavigation { get; set; }

    public virtual Buyer LoginBuyerNavigation { get; set; } = null!;

    public virtual Specialist LoginSpecNavigation { get; set; } = null!;
}
