using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsSalaryMode
{
    public int SalaryModeId { get; set; }

    public string? SalaryMode { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryModeActive { get; set; }
}
