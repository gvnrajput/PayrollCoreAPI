using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollTdspriorInvestment
{
    public int TdspriorInvestmentId { get; set; }

    public int? EmpId { get; set; }

    public int? TdstypeId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? FinancialYearId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? VerifyStatus { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? AmountDifference { get; set; }
}
