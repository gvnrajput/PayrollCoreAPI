using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class ViewMonthWiseSalaryRanchi
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeCode { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public DateTime? JoiningDate { get; set; }

    public int? MonthDays { get; set; }

    public string? MonthName { get; set; }

    public decimal? SalaryDays { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ActualAmount { get; set; }

    public int? LocationId { get; set; }

    public string? SalaryGradeName { get; set; }

    public int? FinancialyearId { get; set; }

    public string? FinalcialYear { get; set; }

    public string? LocationName { get; set; }
}
