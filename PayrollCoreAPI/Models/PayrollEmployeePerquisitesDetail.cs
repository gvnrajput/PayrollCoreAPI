using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollEmployeePerquisitesDetail
{
    public int EmployeePerquisitesDetails { get; set; }

    public int? PerquisitesId { get; set; }

    public int? EmployeeId { get; set; }

    public int? FinancialYearId { get; set; }

    public decimal? MaxValue { get; set; }

    public decimal? AsPerRule { get; set; }

    public decimal? AmountRecoveredFromEmployee { get; set; }

    public decimal? AmountchargabletoTax { get; set; }

    public bool? EmployeePerquisitesDetailsActive { get; set; }
}
