using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Candidate
{
    public decimal CandidateId { get; set; }

    public string? CandidateCode { get; set; }

    public string? CandidateName { get; set; }

    public int? NationaityId { get; set; }

    public string? Gender { get; set; }

    public int? ReligionId { get; set; }

    public DateTime? Dob { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? TelNo { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Fittness { get; set; }

    public string? CandHealth { get; set; }

    public string? CandIllness { get; set; }

    public int? MaritalStatusId { get; set; }

    public string? CandDependents { get; set; }

    public string? FathHusbName { get; set; }

    public string? Profession { get; set; }

    public string? Category { get; set; }

    public string? CandParticulars { get; set; }

    public string? CandPhysicalProblems { get; set; }

    public string? MotherName { get; set; }

    public bool? IsSelected { get; set; }

    public bool? IsCancel { get; set; }

    public int? BloodGroup { get; set; }

    public DateTime? AppliedDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public decimal? GrossSalary { get; set; }

    public string? Remarks { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? CandidateActive { get; set; }
}
