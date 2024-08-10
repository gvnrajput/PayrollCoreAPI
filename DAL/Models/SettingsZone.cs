using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsZone
{
    public int ZoneId { get; set; }

    public string? ZoneName { get; set; }

    public bool? ZoneActive { get; set; }
}
