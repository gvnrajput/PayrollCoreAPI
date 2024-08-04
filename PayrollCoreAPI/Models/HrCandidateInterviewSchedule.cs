using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateInterviewSchedule
{
    public decimal CandidateInterviewScheduleId { get; set; }

    public int? InterviewerScheduleId { get; set; }

    public int? CvuploadId { get; set; }

    public string? CandidateStatus { get; set; }

    public string? Rating { get; set; }

    public bool? Notify { get; set; }

    public string? SelectionStatus { get; set; }

    public DateTime? InterviewDate { get; set; }

    public TimeOnly? InterviewTime { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public string? Comment { get; set; }

    public bool? CandidateInterviewScheduleActive { get; set; }
}
