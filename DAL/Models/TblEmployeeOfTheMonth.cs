using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblEmployeeOfTheMonth
{
    public int EmpMonthId { get; set; }

    public string? Month { get; set; }

    public int? EmployeeId { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
