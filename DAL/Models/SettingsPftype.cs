using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsPftype
{
    public int PftypeId { get; set; }

    public string? Pftype { get; set; }

    public bool? PftypeActive { get; set; }
}
