using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AuditEmployeeSalaryHeadDetail
{
    public decimal ImportsSalaryHeadDetailId { get; set; }

    public int? SalaryHeadDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public int? SalaryStructureId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public string? AuditAction { get; set; }

    public DateTime? ActionDate { get; set; }
}
