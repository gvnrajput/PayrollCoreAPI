using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollSalaryTranfer
{
    public int SalaryTranferId { get; set; }

    public int? EmployeeId { get; set; }

    public string? PaymentMode { get; set; }

    public decimal? SalaryPaid { get; set; }

    public int? CompanyAccountId { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryTranferActive { get; set; }
}
