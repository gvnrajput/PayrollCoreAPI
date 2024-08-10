using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollAttendance
{
    public int AttendanceId { get; set; }

    public int? MonthDays { get; set; }

    public int? Holidays { get; set; }

    public int? WorkingDays { get; set; }

    public int? WeeklyHolidays { get; set; }

    public int? MonthId { get; set; }

    public int? SalaryCycleId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public string? AttendanceStatus { get; set; }

    public bool? AttendanceActive { get; set; }
}
