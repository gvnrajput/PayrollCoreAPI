using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCity
{
    public int CityId { get; set; }

    public int? StateId { get; set; }

    public string? CityName { get; set; }

    public bool? CityActive { get; set; }
}
