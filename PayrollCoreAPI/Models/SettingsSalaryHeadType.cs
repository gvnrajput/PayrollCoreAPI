using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsSalaryHeadType
{
    public int SalaryHeadTypeId { get; set; }

    public string? SalaryHeadTypeName { get; set; }

    public bool? SalaryHeadTypeActive { get; set; }
}
