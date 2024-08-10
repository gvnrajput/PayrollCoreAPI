using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollSalaryIncrement
{
    public int SalaryIncrementId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? Wefdate { get; set; }

    public DateTime? RequstedDate { get; set; }

    public decimal? PercentageIncrement { get; set; }

    public decimal? AmountTobe { get; set; }

    public decimal? IncrementAmount { get; set; }

    public decimal? Ctc { get; set; }

    public decimal? PreviousCtc { get; set; }

    public string? Remarks { get; set; }

    public string? IncrementType { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryIncrementActive { get; set; }

    public int? FinancialYearId { get; set; }
}
