using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollEmployeeForm16Detail
{
    public int EmployeeForm16DetailsId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? CreatedDateDate { get; set; }

    public decimal? GrossSalary { get; set; }

    public decimal? ValueOfPerquisite { get; set; }

    public decimal? ProfitunderSection173 { get; set; }

    public decimal? TotalAll { get; set; }

    public decimal? AllowanceLess { get; set; }

    public decimal? Conveyance { get; set; }

    public decimal? Hra { get; set; }

    public decimal? Lta { get; set; }

    public decimal? Balance12 { get; set; }

    public decimal? Entertainment { get; set; }

    public decimal? TaxOnEmployement { get; set; }

    public decimal? Epf1 { get; set; }

    public decimal? Epf2 { get; set; }

    public decimal? Section80Ccc1 { get; set; }

    public decimal? Section80Ccc2 { get; set; }

    public decimal? Section80Ccd1 { get; set; }

    public decimal? Section80Ccd2 { get; set; }

    public decimal? DeductionUnderChapter6 { get; set; }

    public decimal? TotalIncome { get; set; }

    public decimal? TaxOnTotalIncome { get; set; }

    public decimal? TaxPayable1213 { get; set; }

    public decimal? LessReliefUnderSection89 { get; set; }

    public decimal? TaxPayable1415 { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? CreatedBy { get; set; }

    public bool? EmployeeForm16DetailsActive { get; set; }
}
