using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsDesignation
{
    public int DesignationId { get; set; }

    public int? DepartmentId { get; set; }

    public string? DesignationName { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? DesignationActive { get; set; }
}
