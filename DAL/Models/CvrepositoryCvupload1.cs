using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CvrepositoryCvupload1
{
    public int CvuploadId { get; set; }

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

    public string? EntryType { get; set; }

    public int? UserId { get; set; }

    public string? ExperienceI { get; set; }
}
