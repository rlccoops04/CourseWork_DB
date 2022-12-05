﻿using System;
using System.Collections.Generic;

namespace Agency.Models;

public partial class Owner
{
    public string FioOwner { get; set; } = null!;

    public string PassportNumOwner { get; set; } = null!;

    public string NomTelOwner { get; set; } = null!;

    public string LoginOwner { get; set; } = null!;

    public string PasswordOwner { get; set; } = null!;

    public virtual ICollection<Apartment> Apartments { get; } = new List<Apartment>();
}
