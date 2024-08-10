using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCompanyGroup
{
    public int CompanyGroupId { get; set; }

    public string? CompanyGroupName { get; set; }

    public bool? CompanyGroupActive { get; set; }
}
