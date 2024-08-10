using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsPolicyDetail
{
    public int PolicyDetailId { get; set; }

    public string? PolicyDetailName { get; set; }

    public int? DepartmentId { get; set; }

    public int? EmployeeId { get; set; }

    public int? FinYearId { get; set; }

    public string? Description { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public string? DocumentUrl { get; set; }

    public byte[]? DocumentLogo { get; set; }

    public bool? PolicyDetailsActive { get; set; }
}
