using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeAadharRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AadharEnrollmentNo { get; set; }

    public string? NameAsPerAadhar { get; set; }

    public int? Status { get; set; }
}
