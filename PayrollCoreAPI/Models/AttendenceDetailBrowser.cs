using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendenceDetailBrowser
{
    public decimal AttendenceDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly? AttDate { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public DateTime? ActualInTime { get; set; }

    public DateTime? ActualOutTime { get; set; }

    public DateTime? LunchOut { get; set; }

    public DateTime? LunchIn { get; set; }

    public TimeOnly? ActualLunchOut { get; set; }

    public TimeOnly? ActualLunchIn { get; set; }

    public string? StayedOn { get; set; }

    public decimal? OverTimeMinute { get; set; }

    public string? Presence { get; set; }

    public string? Remarks { get; set; }

    public string? Ipaddress { get; set; }

    public string? Pcname { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool AttendenceDetailActive { get; set; }

    public int? LateMinuteAllowed { get; set; }

    public bool? Smsstatus { get; set; }

    public string? AttendanceLocation { get; set; }

    public string? AttendanceOutLocation { get; set; }
}
