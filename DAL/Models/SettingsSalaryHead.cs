using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsSalaryHead
{
    public int SalaryHeadId { get; set; }

    public int? SalaryHeadTypeId { get; set; }

    public string? SalaryComponentName { get; set; }

    public string? Description { get; set; }

    public int? ProcessSequence { get; set; }

    public bool? SalaryHeadActive { get; set; }

    public int? SalaryType { get; set; }

    public bool? Show { get; set; }

    public int? Wef { get; set; }
}
