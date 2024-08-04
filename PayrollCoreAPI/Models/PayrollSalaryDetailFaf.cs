using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollSalaryDetailFaf
{
    public int SalaryDetailId { get; set; }

    public int? SalaryHeaderId { get; set; }

    public int? EmployeeId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? Amount { get; set; }
}
