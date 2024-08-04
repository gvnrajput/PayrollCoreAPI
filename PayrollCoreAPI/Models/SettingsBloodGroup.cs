using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsBloodGroup
{
    public int BloodGroupId { get; set; }

    public string? BloodGroupName { get; set; }

    public bool? BloodGroupActive { get; set; }
}
