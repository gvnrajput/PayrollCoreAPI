using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AttendanceEss
{
    public decimal AttendanceEssid { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? AttendanceIn { get; set; }

    public DateTime? AttendanceOut { get; set; }

    public string? Presence { get; set; }

    public string? Reason { get; set; }

    public DateTime? LunchOut { get; set; }

    public DateTime? LunchIn { get; set; }

    public string? Ipaddress { get; set; }

    public string? Pcname { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? Status { get; set; }

    public string? AttendanceLocation { get; set; }

    public string? EmpAttendanceImage { get; set; }

    public string? AttendanceOutLocation { get; set; }
}
