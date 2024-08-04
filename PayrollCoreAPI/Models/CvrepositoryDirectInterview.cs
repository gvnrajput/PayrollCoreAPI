using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class CvrepositoryDirectInterview
{
    public int? CvuploadId { get; set; }

    public int DirectInterviewId { get; set; }

    public string? DirectInterviewCode { get; set; }

    public int? ManpowerRequisationId { get; set; }

    public int? CvtypeId { get; set; }

    public string? Specialisation { get; set; }

    public string? PassportNo { get; set; }

    public string? Experience { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? ResumePath { get; set; }

    public int? ReligionId { get; set; }

    public bool? Cvstatus { get; set; }

    public bool? CvuploadActive { get; set; }

    public string? CandidateName { get; set; }

    public string? MobileNo { get; set; }

    public string? Email { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? InterviewDate { get; set; }
}
