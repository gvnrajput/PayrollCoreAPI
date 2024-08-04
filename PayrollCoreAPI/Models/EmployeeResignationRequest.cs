using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeResignationRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public int? LeavingReasonId { get; set; }

    public DateTime? ResignSubmitted { get; set; }

    public int? NoticePeriod { get; set; }

    public int? Status { get; set; }

    public string? ResignationReason { get; set; }

    public bool? IsActive { get; set; }

    public bool? ManagerAccepted { get; set; }

    public DateTime? ManagerAcceptedDate { get; set; }
}
