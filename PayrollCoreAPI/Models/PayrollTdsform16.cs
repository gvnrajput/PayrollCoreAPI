using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollTdsform16
{
    public int Tdsform16Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? TdsclaimId { get; set; }

    public decimal? BilledAmount { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public string? Tdstype { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? Tdsform16Active { get; set; }
}
