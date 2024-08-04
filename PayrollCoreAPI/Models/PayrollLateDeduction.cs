using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollLateDeduction
{
    public int LateDeductionId { get; set; }

    public int? ShiftId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? AllowLateDays { get; set; }

    public decimal? Deduction { get; set; }

    public bool? DeductionStatus { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LateDeductionActive { get; set; }
}
