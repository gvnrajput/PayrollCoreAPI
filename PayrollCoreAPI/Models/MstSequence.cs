using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstSequence
{
    public int Sid { get; set; }

    public int? FormId { get; set; }

    public string? Head { get; set; }

    public string? Prefix { get; set; }

    public decimal? Start { get; set; }

    public decimal? LastValue { get; set; }

    public string? Value { get; set; }

    public int? Increment { get; set; }

    public bool? IsFinYear { get; set; }

    public bool? IscodeSeparator { get; set; }

    public string? Separator { get; set; }

    public decimal? LastValueUpdate { get; set; }

    public bool IsActive { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }
}
