using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollOtherEntitlementDetail
{
    public decimal OtherEntitlementId { get; set; }

    public int? AttendanceId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? EmployeeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? OtherEntitlementActive { get; set; }
}
