using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsAttendanceSchedule
{
    public decimal AttendanceScheduleId { get; set; }

    public bool? DownloadIntervalStatus { get; set; }

    public decimal? Interval { get; set; }

    public DateTime? MannualTime { get; set; }

    public int? CompanyId { get; set; }

    public bool? AttendanceScheduleActive { get; set; }
}
