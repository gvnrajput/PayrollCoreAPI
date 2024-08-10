using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SequenceMaster
{
    public string Head { get; set; } = null!;

    public string? Prefix { get; set; }

    public decimal? Start { get; set; }

    public decimal? Stop { get; set; }

    public decimal? Increment { get; set; }

    public decimal? LastValue { get; set; }

    public bool? CanBeModified { get; set; }

    public bool? MachineSerialNo { get; set; }

    public bool? FinancialYear { get; set; }

    public bool? ChangeInFinYear { get; set; }

    public int? UnitId { get; set; }
}
