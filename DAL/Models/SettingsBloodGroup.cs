using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsBloodGroup
{
    public int BloodGroupId { get; set; }

    public string? BloodGroupName { get; set; }

    public bool? BloodGroupActive { get; set; }
}
