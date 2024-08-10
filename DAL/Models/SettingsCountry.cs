using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCountry
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public bool? CountryActive { get; set; }
}
