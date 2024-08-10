using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrInterviewDetail
{
    public decimal InterviewDetails { get; set; }

    public int? InterviewScheduleId { get; set; }

    public int? CvuploadId { get; set; }

    public string? InterviewStatus { get; set; }

    public bool? InterviewDetailsActive { get; set; }
}
