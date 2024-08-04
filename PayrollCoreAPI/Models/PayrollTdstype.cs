using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollTdstype
{
    public int TdstypeId { get; set; }

    public string? TdstypeName { get; set; }

    public bool? TdstypeActive { get; set; }
}
