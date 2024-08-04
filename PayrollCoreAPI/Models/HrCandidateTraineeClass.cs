using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateTraineeClass
{
    public int ClassDetailId { get; set; }

    public int? CandidateNo { get; set; }

    public string? AppliedCourse { get; set; }

    public int? Duration { get; set; }

    public string? Skills { get; set; }

    public int? NoOfClass { get; set; }

    public int? NoOfStudent { get; set; }

    public int? Department { get; set; }

    public string? Faculty { get; set; }

    public string? CourseAmount { get; set; }

    public DateTime? ClassStartDate { get; set; }

    public DateTime? ClassEndDate { get; set; }

    public string? Discription { get; set; }

    public bool? CandidateActive { get; set; }
}
