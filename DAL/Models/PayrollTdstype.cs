using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollTdstype
{
    public int TdstypeId { get; set; }

    public string? TdstypeName { get; set; }

    public bool? TdstypeActive { get; set; }
}
