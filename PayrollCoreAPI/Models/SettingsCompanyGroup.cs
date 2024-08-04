using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsCompanyGroup
{
    public int CompanyGroupId { get; set; }

    public string? CompanyGroupName { get; set; }

    public bool? CompanyGroupActive { get; set; }
}
