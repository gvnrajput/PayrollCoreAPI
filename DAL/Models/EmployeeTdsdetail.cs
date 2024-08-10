using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeTdsdetail
{
    public int EmployeeTdsdetails { get; set; }

    public int? EmployeeId { get; set; }

    public int? IncludeInSalary { get; set; }

    public decimal? GrossSalary { get; set; }

    public decimal? Tdsslab { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? PercentageAmount { get; set; }

    public decimal? AmountPerYear { get; set; }

    public decimal? AmountPerMonth { get; set; }
}
