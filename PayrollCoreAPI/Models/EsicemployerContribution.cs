using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EsicemployerContribution
{
    public int Esicecid { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? Amount { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? Esicecactive { get; set; }
}
