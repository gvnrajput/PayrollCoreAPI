using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollAttendanceDetailFaf
{
    public int AttendanceDetailId { get; set; }

    public int? AttendanceId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? SalaryDays { get; set; }

    public decimal? PresentDays { get; set; }

    public decimal? AbsentDays { get; set; }

    public decimal? TotalLateDays { get; set; }

    public decimal? LateDeductionDays { get; set; }

    public decimal? Deduction { get; set; }

    public decimal? WeeklyOff { get; set; }
}
