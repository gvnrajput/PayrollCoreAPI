using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeSalaryHeadDetail
{
    public int SalaryHeadDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public int? SalaryStructureId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }
}
