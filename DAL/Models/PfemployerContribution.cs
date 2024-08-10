using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PfemployerContribution
{
    public int Pfecid { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? Epsamount { get; set; }

    public decimal? Epfamount { get; set; }

    public decimal? Ncpdays { get; set; }

    public decimal? AdminCharge { get; set; }

    public decimal? EdliCharges { get; set; }

    public decimal? EdliAdminCharges { get; set; }

    public decimal? RefundAdvance { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? PaidStatus { get; set; }

    public bool? Pfecactive { get; set; }
}
