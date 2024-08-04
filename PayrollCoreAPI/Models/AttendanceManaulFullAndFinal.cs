using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendanceManaulFullAndFinal
{
    public int FafmanaulAttendanceId { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeCode { get; set; }

    public decimal? SalaryDays { get; set; }

    public decimal? Lop { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? ManaulAttendanceActive { get; set; }

    public decimal? WeeklyOff { get; set; }
}
