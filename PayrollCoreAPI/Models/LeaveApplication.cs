using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class LeaveApplication
{
    public int LeaveApplicationId { get; set; }

    public int? LeaveTypeId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? FromHalfDay { get; set; }

    public string? ToHalfDay { get; set; }

    public DateTime? LeaveFrom { get; set; }

    public DateTime? LeaveTo { get; set; }

    public decimal? NoOfLeaveApplied { get; set; }

    public DateTime? SanctionFrom { get; set; }

    public DateTime? SanctionTo { get; set; }

    public string? SanctionFromHalfDay { get; set; }

    public string? SanctionToHalfDay { get; set; }

    public decimal? NoOfLeaveSanction { get; set; }

    public string? Remarks { get; set; }

    public string? ManagerRemarks { get; set; }

    public string? Hrremarks { get; set; }

    public int? IsApproved { get; set; }

    public int? ApprovedBy { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LeaveApplicationActive { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? RecommendBy { get; set; }

    public DateTime? RecommendedDate { get; set; }
}
