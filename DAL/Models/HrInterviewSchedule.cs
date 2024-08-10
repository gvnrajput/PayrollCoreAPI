using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrInterviewSchedule
{
    public int InterviewScheduleId { get; set; }

    public DateTime? InterviewSchedule { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? InterviewScheduleActive { get; set; }
}
