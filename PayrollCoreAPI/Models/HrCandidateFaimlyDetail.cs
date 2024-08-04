using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateFaimlyDetail
{
    public decimal FaimlyDetailId { get; set; }

    public decimal? CandidateId { get; set; }

    public string? Name { get; set; }

    public int? AgeYear { get; set; }

    public string? RelationShip { get; set; }

    public string? Profession { get; set; }

    public bool? IsRetired { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public bool? IsDependent { get; set; }
}
