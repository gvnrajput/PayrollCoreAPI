using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsMaritalStatus
{
    public int MaritalStatusId { get; set; }

    public string? MaritalStatusName { get; set; }

    public bool? MaritalStatusActive { get; set; }
}
