using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LeaveConfiguration
{
    public int LeaveConfigurationId { get; set; }

    public int? LeaveTypeId { get; set; }

    public bool? EncashmentStatus { get; set; }

    public string? GenderType { get; set; }

    public int? MaritalStatusId { get; set; }

    public string? LeaveTypeDeatils { get; set; }

    public bool? BeginningofMonth { get; set; }

    public decimal? MaxLeave { get; set; }

    public bool? LeaveApplicableStatus { get; set; }

    public decimal? LeaveApplicableAfter { get; set; }

    public bool? ExcludeFestive { get; set; }

    public bool? ExcludeWeekends { get; set; }

    public decimal? MaxconsecutiveLeave { get; set; }

    public decimal? MinimumLeave { get; set; }

    public bool? CarryForward { get; set; }

    public decimal? MaxCarryForward { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? FinancialYearId { get; set; }

    public bool? Payble { get; set; }

    public bool? LeaveConfigurationActive { get; set; }
}
