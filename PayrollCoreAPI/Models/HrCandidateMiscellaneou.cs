using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateMiscellaneou
{
    public int MiscellaneousId { get; set; }

    public decimal? CandidateId { get; set; }

    public string? CandPreviousEmployment { get; set; }

    public string? Recreation { get; set; }

    public string? Abroad { get; set; }

    public string? Visit { get; set; }

    public string? CourtCase { get; set; }

    public string? CourtCaseDetails { get; set; }

    public string? Drive { get; set; }

    public string? DriveDetail { get; set; }

    public string? Vehicle { get; set; }

    public string? WhichVehicle { get; set; }

    public string? Licence { get; set; }

    public string? LicenceDetails { get; set; }

    public string? Ncc { get; set; }

    public string? Rank { get; set; }

    public string? CandServe { get; set; }

    public string? SpentTime { get; set; }

    public string? Membership { get; set; }

    public string? ReferncePerson { get; set; }

    public int? RefDepartmentId { get; set; }

    public int RefrenceEmployeeId { get; set; }
}
