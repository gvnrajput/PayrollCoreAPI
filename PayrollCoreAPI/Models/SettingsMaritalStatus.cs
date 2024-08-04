using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsMaritalStatus
{
    public int MaritalStatusId { get; set; }

    public string? MaritalStatusName { get; set; }

    public bool? MaritalStatusActive { get; set; }
}
