using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendanceShift
{
    public int ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public string? ShiftFrom { get; set; }

    public string? ShiftTo { get; set; }

    public string? Remarks { get; set; }

    public decimal TotalHours { get; set; }

    public decimal? TotalMinutes { get; set; }

    public int? LateAllowed { get; set; }

    public bool? WeeklyOffOnSun { get; set; }

    public bool? WeeklyOffOnMon { get; set; }

    public bool? WeeklyOffOnTue { get; set; }

    public bool? WeeklyOffOnWed { get; set; }

    public bool? WeeklyOffOnThu { get; set; }

    public bool? WeeklyOffOnFri { get; set; }

    public bool? WeeklyOffOnSat { get; set; }

    public bool? HalfOnSun { get; set; }

    public bool? HalfOnMon { get; set; }

    public bool? HalfOnTue { get; set; }

    public bool? HalfOnWed { get; set; }

    public bool? HalfOnThu { get; set; }

    public bool? HalfOnFri { get; set; }

    public bool? HalfOnSat { get; set; }

    public bool? FullOnSun { get; set; }

    public bool? FullOnMon { get; set; }

    public bool? FullOnTue { get; set; }

    public bool? FullOnWed { get; set; }

    public bool? FullOnThu { get; set; }

    public bool? FullOnFri { get; set; }

    public bool? FullOnSat { get; set; }

    public string? LunchIn { get; set; }

    public string? LunchOut { get; set; }

    public bool? LateDaysAllowed { get; set; }

    public int? TotalLateDays { get; set; }

    public bool? TimeFrameAllowed { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? ShiftActive { get; set; }
}
