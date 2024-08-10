using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollTdsclaim
{
    public int TdsclaimId { get; set; }

    public DateTime? ClaimDate { get; set; }

    public string? ReviewerTo { get; set; }

    public string? GeneralRemarks { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? FinancialYearId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? Form16Uploaded { get; set; }
}
