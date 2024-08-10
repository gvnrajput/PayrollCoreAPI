using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsGrade
{
    public int SalaryGradeId { get; set; }

    public string? SalaryGradeName { get; set; }

    public decimal? MinGrossSalary { get; set; }

    public decimal? MaxGrossSalary { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryGradeActive { get; set; }

    public int? NoticePeriod { get; set; }
}
