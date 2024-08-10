using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ErrorSalaryDetail
{
    public string? EmployeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? SalaryGrade { get; set; }

    public string? Remarks { get; set; }
}
