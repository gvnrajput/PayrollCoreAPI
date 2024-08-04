using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrSelectedCandidateDetail
{
    public int SelectedCandidateDetailId { get; set; }

    public int? SelectedCandidateId { get; set; }

    public int? CvuploadId { get; set; }

    public string? ResumePath { get; set; }

    public string? InterviewStatus { get; set; }

    public bool? SelectedCandidateIdDetailsActive { get; set; }

    public int? Status { get; set; }

    public string? Reason { get; set; }

    public bool? IssueedAppointmentLetter { get; set; }

    public bool? IssueedLoi { get; set; }

    public bool? EmployeeMade { get; set; }

    public string? CanidateName { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? DateOfJoining { get; set; }
}
