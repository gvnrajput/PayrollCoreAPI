using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsLocation
{
    public int LocationId { get; set; }

    public int? CompanyId { get; set; }

    public string? LocationName { get; set; }

    public string? LocationAddress { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PhoneNo { get; set; }

    public string? Fax { get; set; }

    public string? EmailId { get; set; }

    public string? Description { get; set; }

    public bool? LocationActive { get; set; }

    public virtual SettingsCompany? Company { get; set; }
}
