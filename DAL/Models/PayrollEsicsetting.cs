using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollEsicsetting
{
    public int EsicsettingId { get; set; }

    public string? Contributor { get; set; }

    public decimal? AmountFrom { get; set; }

    public decimal? AmountTo { get; set; }

    public decimal? ContributerPercentage { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? EsicsettingActive { get; set; }
}
