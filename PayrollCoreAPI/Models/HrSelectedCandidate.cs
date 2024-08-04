using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrSelectedCandidate
{
    public int SelectedCandidateId { get; set; }

    public int? ManpowerrequisationId { get; set; }

    public DateTime? SelectedDate { get; set; }

    public int? UserId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? SelectedCandidateActive { get; set; }

    public string? InterviewerName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }
}
