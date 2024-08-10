using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeePreviousDetail
{
    public int PreviousDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Designation { get; set; }

    public string? CompanyName { get; set; }

    public string? NatureOfDuties { get; set; }

    public string? LeavingReason { get; set; }

    public bool? VerifyStatus { get; set; }
}
