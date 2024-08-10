using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCourse
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? Duration { get; set; }

    public int? NoOfCandidate { get; set; }

    public decimal? Amount { get; set; }

    public string? Remarks { get; set; }

    public int? NoOfClass { get; set; }

    public int? CompanyId { get; set; }

    public bool? CourseActive { get; set; }

    public string? Skills { get; set; }
}
