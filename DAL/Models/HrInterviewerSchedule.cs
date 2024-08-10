using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrInterviewerSchedule
{
    public int InterviewerScheduleId { get; set; }

    public string? ReferenceCode { get; set; }

    public int? EmployeeId { get; set; }

    public int? ForwardeToEmployeeId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public bool? Notify { get; set; }

    public string? Location { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? InterviewerScheduleActive { get; set; }

    public string? IntDepartmentId { get; set; }
}
