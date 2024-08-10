using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingEmployeeOfTheMonth
{
    public int EmpMonthId { get; set; }

    public string? Month { get; set; }

    public int? EmployeeId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? IsActiveStatus { get; set; }
}
