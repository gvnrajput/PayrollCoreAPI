using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollTdsclaimDetail
{
    public int TdsclaimDetailId { get; set; }

    public int? TdsclaimId { get; set; }

    public int? TdstypeId { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BilledAmount { get; set; }

    public string? Remarks { get; set; }

    public int? ClaimStatusId { get; set; }

    public int? UserClaimStatus { get; set; }

    public string? AttachBill { get; set; }

    public decimal? ApprovedAmount { get; set; }
}
