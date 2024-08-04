using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class ErrorEmployee
{
    public string? EmployeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Remarks { get; set; }
}
