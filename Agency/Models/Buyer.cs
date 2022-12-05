using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Buyer
{
    public string FioBuyer { get; set; } = null!;

    public string PassportNumBuyer { get; set; } = null!;

    public string NomTelBuyer { get; set; } = null!;

    public string LoginBuyer { get; set; } = null!;

    public string PasswordBuyer { get; set; } = null!;

    public virtual ICollection<Deal> Deals { get; } = new List<Deal>();

    public virtual ICollection<Request> Requests { get; } = new List<Request>();
}
