using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateExtraCurricular
{
    public int ExtraCurricularId { get; set; }

    public decimal? CandidateId { get; set; }

    public string? InstitutionName { get; set; }

    public string? Activities { get; set; }

    public string? PositionOfficeHeld { get; set; }
}
