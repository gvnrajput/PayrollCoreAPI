using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidatePreviousDetail
{
    public int PreviousDetailId { get; set; }

    public decimal? CandidateId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Designation { get; set; }

    public string? CompanyName { get; set; }

    public string? NatureOfDuties { get; set; }

    public string? LeavingReason { get; set; }
}
