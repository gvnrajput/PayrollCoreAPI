﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class RembursementClaimDetail
{
    public int RclaimDetailId { get; set; }

    public int? RembursementClaimId { get; set; }

    public int? RembursementTypeId { get; set; }

    public string? BillNo { get; set; }

    public DateTime? BillDate { get; set; }

    public decimal? BilledAmount { get; set; }

    public string? Remarks { get; set; }

    public int? ClaimStatusId { get; set; }

    public int? UserClaimStatus { get; set; }

    public string? AttachBill { get; set; }

    public decimal? ApprovedAmount { get; set; }
}
