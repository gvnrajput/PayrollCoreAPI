using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateTraineQualification
{
    public int QualificationDetailId { get; set; }

    public int? CandidateNo { get; set; }

    public int? QualificationId { get; set; }

    public string? PassingYear { get; set; }

    public int? Duration { get; set; }

    public string? InstituteName { get; set; }

    public string? UniversityName { get; set; }

    public string? QualificationArea { get; set; }

    public string? Remarks { get; set; }

    public bool? CandidateActive { get; set; }
}
