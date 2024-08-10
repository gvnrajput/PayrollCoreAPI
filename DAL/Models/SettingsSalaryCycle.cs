using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsSalaryCycle
{
    public int SalaryCycleId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? PaidDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryCycleActive { get; set; }
}
