using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ViewEmployeeLeaveDetailsDehradoon
{
    public string? EmployeeName { get; set; }

    public string? EmployeCode { get; set; }

    public string? LeaveType { get; set; }

    public string? Status { get; set; }

    public DateOnly? RequestDate { get; set; }

    public DateOnly? LeaveFrom { get; set; }

    public DateOnly? LeaveTo { get; set; }

    public decimal? NoOfLeaveApplied { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? RecommendedDate { get; set; }

    public string? RecomendedBy { get; set; }

    public DateOnly? ApprovedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public int? LocationId { get; set; }
}
