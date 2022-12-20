using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Specialist
{
    public string FioSpec { get; set; } = null!;

    public string NomTelSpec { get; set; } = null!;

    public int CountDeals { get; set; }

    public int? SalarySpec { get; set; }

    public string PasswordSpec { get; set; } = null!;

    public string LoginSpec { get; set; } = null!;

    public int IdSpec { get; set; }

    public string PassportNumSpec { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();
}
