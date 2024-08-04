using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateinfo
{
    public int CandidateNo { get; set; }

    public string? CandidateCode { get; set; }

    public string? Name { get; set; }

    public string? Purpose { get; set; }

    public string? Category { get; set; }

    public string? Applied { get; set; }

    public string? Skill { get; set; }

    public int? Intstitute { get; set; }

    public DateTime? AppliedDate { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? PlaceBirth { get; set; }

    public string? Nationality { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNo { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? PhysicalChallenge { get; set; }

    public string? PhysicalType { get; set; }

    public string? RefereceName { get; set; }

    public string? RefMobile { get; set; }

    public string? RefEmail { get; set; }

    public string? ImageUrl { get; set; }

    public bool? Refernce { get; set; }

    public bool? Hasleft { get; set; }

    public bool? CandidateActive { get; set; }
}
