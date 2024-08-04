using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AuditEmployeeRoster
{
    public decimal AuditRosterId { get; set; }

    public int? EmployeeRosterId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShiftId { get; set; }

    public string? Scheduling { get; set; }

    public DateTime? SchDate { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? AuditAction { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
