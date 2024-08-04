using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class TblTaskAssignment
{
    public int TaskAssignmentId { get; set; }

    public int? AssignedTo { get; set; }

    public int? AssignedBy { get; set; }

    public string? AssignedWork { get; set; }

    public string? Priority { get; set; }

    public DateOnly? StartDate { get; set; }

    public TimeOnly? TimeFrom { get; set; }

    public DateOnly? EndDate { get; set; }

    public TimeOnly? TimeTo { get; set; }

    public int? GraceTime { get; set; }

    public DateTime? EstimatedTimeFrom { get; set; }

    public DateTime? EstimatedTimeTo { get; set; }

    public DateTime? GraceEstimatedTime { get; set; }

    public string? TaskStatus { get; set; }

    public string? Remark { get; set; }

    public string? RemarkByManager { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelledBy { get; set; }

    public DateTime? SubmitDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? ReadStatus { get; set; }

    public bool? IsActiveStatus { get; set; }

    public string? SubmitTaskPath { get; set; }

    public string? TaskPath { get; set; }
}
