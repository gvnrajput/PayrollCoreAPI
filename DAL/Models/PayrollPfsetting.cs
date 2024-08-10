using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollPfsetting
{
    public int PfsettingId { get; set; }

    public string? Contributor { get; set; }

    public string? Pftype { get; set; }

    public decimal? ContributionPercent { get; set; }

    public decimal? MaxAmount { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? PfsettingActive { get; set; }
}
