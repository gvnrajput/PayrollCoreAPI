using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendanceTimeFrame
{
    public int TimeFrameId { get; set; }

    public int? FinancialYearId { get; set; }

    public bool? InTimeStatus { get; set; }

    public bool? OutTimeStatus { get; set; }

    public string? TimeAfter { get; set; }

    public string? TimeBefore { get; set; }

    public decimal? PercOfDeduct { get; set; }

    public int? ShiftId { get; set; }

    public string? TimeStatus { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? TimeFrameActive { get; set; }
}
