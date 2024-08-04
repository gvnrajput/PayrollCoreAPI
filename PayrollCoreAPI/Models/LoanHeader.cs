using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class LoanHeader
{
    public decimal LoanId { get; set; }

    public int EmployeeId { get; set; }

    public string LoanCode { get; set; } = null!;

    public DateTime ApplicationDate { get; set; }

    public string? LoanStatus { get; set; }

    public string? LoanReason { get; set; }

    public string? LoanType { get; set; }

    public int? IsGranted { get; set; }

    public decimal LoanAmount { get; set; }

    public decimal? SanctionAmount { get; set; }

    public decimal InsAmount { get; set; }

    public decimal? SanctionInsAmount { get; set; }

    public DateTime AppInstDate { get; set; }

    public DateTime? SanInstDate { get; set; }

    public decimal? NoOfInst { get; set; }

    public DateTime? ClearedDate { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal? BalanceAmount { get; set; }

    public bool? IsPaid { get; set; }

    public string? ModifiedDetailsBy { get; set; }

    public decimal? SanctionAmountC { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }
}
