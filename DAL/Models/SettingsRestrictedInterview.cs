using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsRestrictedInterview
{
    public int RestrictedInterviewId { get; set; }

    public int? CvtypeId { get; set; }

    public int? RescheduleMinDays { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? RestrictedInterviewActive { get; set; }
}
