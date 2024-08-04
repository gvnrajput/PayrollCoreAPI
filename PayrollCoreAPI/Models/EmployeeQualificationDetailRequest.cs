using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeQualificationDetailRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public int? QualificationId { get; set; }

    public string? PassingYear { get; set; }

    public int? Duration { get; set; }

    public string? InstituteName { get; set; }

    public string? UniversityName { get; set; }

    public string? QualificationArea { get; set; }

    public string? Remarks { get; set; }

    public int? Status { get; set; }
}
