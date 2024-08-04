using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendanceLogBiometric
{
    public decimal AttendanceBiometricsId { get; set; }

    public int? EmployeeId { get; set; }

    public string? CardNo { get; set; }

    public DateTime? AttendanceTime { get; set; }

    public int? Iomode { get; set; }

    public string? Presence { get; set; }

    public string? Reason { get; set; }

    public string? Ipaddress { get; set; }

    public string? Location { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? Status { get; set; }
}
