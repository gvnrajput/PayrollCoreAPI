using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class OnDutySlip
{
    public int OnDutySlipId { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? EmployeeId { get; set; }

    public string? CustomerVisited { get; set; }

    public string? TimeOfVisit { get; set; }

    public string? TimeInOffice { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? IsActiveStatus { get; set; }

    public int? IsApproved { get; set; }
}
