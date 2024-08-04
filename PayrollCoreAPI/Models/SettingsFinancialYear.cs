using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsFinancialYear
{
    public int FinancialYearId { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public bool? FinancialYearActive { get; set; }
}
