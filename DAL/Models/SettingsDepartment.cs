using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsDepartment
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? DepartmentActive { get; set; }
}
