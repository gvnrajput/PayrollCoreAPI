using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsState
{
    public int StateId { get; set; }

    public int? CountryId { get; set; }

    public string? StateName { get; set; }

    public bool? StateActive { get; set; }
}
