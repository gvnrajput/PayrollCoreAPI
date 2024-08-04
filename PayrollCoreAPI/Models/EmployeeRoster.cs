using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeRoster
{
    public int EmployeeRosterId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShiftId { get; set; }

    public string? Scheduling { get; set; }

    public DateTime? SchDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
