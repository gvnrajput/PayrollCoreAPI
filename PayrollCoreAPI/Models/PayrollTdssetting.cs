using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollTdssetting
{
    public int TdssettingId { get; set; }

    public int? CategoryId { get; set; }

    public decimal? AmountExempted { get; set; }

    public decimal? Percentage { get; set; }

    public bool? TdssettingActive { get; set; }

    public decimal? AmountExemptedto { get; set; }

    public int? Sequence { get; set; }

    public decimal? Rebate { get; set; }
}
