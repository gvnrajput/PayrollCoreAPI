using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RembursementClaim
{
    public int RembursementClaimId { get; set; }

    public DateTime? ClaimDate { get; set; }

    public string? ReviewerTo { get; set; }

    public string? GeneralRemarks { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? FinancialYearId { get; set; }
}
