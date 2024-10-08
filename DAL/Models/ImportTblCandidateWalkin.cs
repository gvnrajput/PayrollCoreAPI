﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ImportTblCandidateWalkin
{
    public string? Cvtype { get; set; }

    public string? Specialisation { get; set; }

    public string? Experience { get; set; }

    public string? PassportNo { get; set; }

    public string? CandidateName { get; set; }

    public string? MobileNo { get; set; }

    public string? CountryName { get; set; }

    public string? StateName { get; set; }

    public string? CityName { get; set; }

    public string? Religion { get; set; }

    public string? ResumePath { get; set; }

    public DateTime? Dob { get; set; }

    public string? DirectInterviewCode { get; set; }
}
