using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsEmployeeStatus
{
    public int EmployeeStatusId { get; set; }

    public string? EmployeeStatus { get; set; }

    public bool? EmployeeStatusActive { get; set; }
}
