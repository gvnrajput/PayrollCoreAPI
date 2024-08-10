using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsVigilance
{
    public int VigilanceId { get; set; }

    public string? VigilanceName { get; set; }

    public string? Remarks { get; set; }

    public int? CompanyId { get; set; }

    public bool? VigilanceActive { get; set; }
}
