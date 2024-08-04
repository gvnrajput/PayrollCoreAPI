using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeFullAndFinal
{
    public int FullAndFinalId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AccountReview { get; set; }

    public string? Hrreview { get; set; }

    public string? ProjectHandOver { get; set; }

    public string? OverAllReview { get; set; }

    public bool? Released { get; set; }

    public DateTime? ReleasedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? EmployeeFullAndFinalActive { get; set; }

    public string? PerformanceReview { get; set; }
}
