using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCompany
{
    public int CompanyId { get; set; }

    public int? CompanyGroupId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PhoneNo { get; set; }

    public string? Fax { get; set; }

    public string? EmailId { get; set; }

    public string? Website { get; set; }

    public string? CompanyImgUrl { get; set; }

    public byte[]? CompanyLogo { get; set; }

    public string? Description { get; set; }

    public bool? CompanyActive { get; set; }

    public string? RegNo { get; set; }

    public string? PanNo { get; set; }

    public string? TinNo { get; set; }

    public string? EccNo { get; set; }

    public string? CstNo { get; set; }

    public string? Collectorate { get; set; }

    public string? Hgstno { get; set; }

    public string? ServiceTaxNo { get; set; }

    public string? ExciseRange { get; set; }

    public string? ExciseAddress { get; set; }

    public string? ExciseDiv { get; set; }

    public string? CompanyLicNo { get; set; }

    public string? PrimaryOwner { get; set; }

    public virtual ICollection<SettingsLocation> SettingsLocations { get; set; } = new List<SettingsLocation>();
}
