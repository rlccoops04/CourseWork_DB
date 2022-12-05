using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Request
{
    public int IdReq { get; set; }

    public DateTime DataReq { get; set; }

    public double LiveSpaceReq { get; set; }

    public double GeneralSpaceReq { get; set; }

    public int CountRoomsReq { get; set; }

    public int FloorReq { get; set; }

    public string TypePostrReq { get; set; } = null!;

    public int YearPostrReq { get; set; }

    public string? MetroReq { get; set; }

    public string? FurnitureReq { get; set; }

    public decimal MaxPriceReq { get; set; }

    public string LoginBuyer { get; set; } = null!;

    public virtual Buyer LoginBuyerNavigation { get; set; } = null!;
}
