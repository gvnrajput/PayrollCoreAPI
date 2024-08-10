using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrCandidateOfferLetter
{
    public decimal OfferLetterId { get; set; }

    public int? CandidateInterviewScheduleId { get; set; }

    public string? OfferLetterCode { get; set; }

    public string? CandidateName { get; set; }

    public string? FathHusbName { get; set; }

    public string? MotherName { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public string? TelNo { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public string? Address { get; set; }

    public int? MaritalStatusId { get; set; }

    public DateTime? JoiningDate { get; set; }

    public DateTime? ValidDate { get; set; }

    public string? JoiningStatus { get; set; }

    public decimal? BasicSalary { get; set; }

    public int? SalaryGradeId { get; set; }

    public string? Remarks { get; set; }

    public string? CandidateType { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? OfferLetterActive { get; set; }
}
