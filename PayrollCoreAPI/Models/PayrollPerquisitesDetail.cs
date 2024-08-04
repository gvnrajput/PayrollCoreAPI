using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollPerquisitesDetail
{
    public int PerquisitesId { get; set; }

    public string? PerquisitesName { get; set; }

    public string? Description { get; set; }

    public int? ProcessSequence { get; set; }

    public decimal? MaxValue { get; set; }

    public bool? PerquisitesActive { get; set; }
}
