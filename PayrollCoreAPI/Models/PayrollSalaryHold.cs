using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollSalaryHold
{
    public int SalaryHoldId { get; set; }

    public int? EmployeeId { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryHoldActive { get; set; }
}
