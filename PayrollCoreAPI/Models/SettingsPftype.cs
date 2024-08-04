using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsPftype
{
    public int PftypeId { get; set; }

    public string? Pftype { get; set; }

    public bool? PftypeActive { get; set; }
}
