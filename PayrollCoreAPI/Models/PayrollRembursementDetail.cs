using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollRembursementDetail
{
    public int RembursementDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public int? RembursementHeadId { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? Amount { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }
}
