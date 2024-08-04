using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeePreviousDetailRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Designation { get; set; }

    public string? CompanyName { get; set; }

    public string? NatureOfDuties { get; set; }

    public string? LeavingReason { get; set; }

    public int? Status { get; set; }
}
