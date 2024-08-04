using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollLoanApplication
{
    public int LoanAppId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? ApplyDate { get; set; }

    public string? LoanReason { get; set; }

    public int? LoanTypeId { get; set; }

    public int? IsGranted { get; set; }

    public decimal? LoanAmount { get; set; }

    public decimal? SanctionAmount { get; set; }

    public decimal? InsAmount { get; set; }

    public decimal? SanctionInsAmount { get; set; }

    public DateTime? AppInstDate { get; set; }

    public DateTime? SanInstDate { get; set; }

    public int? NoOfInst { get; set; }

    public int? NoOfSanctionInst { get; set; }

    public DateTime? ClearedDate { get; set; }

    public int? SanctionBy { get; set; }

    public decimal? BalanceAmount { get; set; }

    public bool? IsPaid { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LoanActive { get; set; }
}
