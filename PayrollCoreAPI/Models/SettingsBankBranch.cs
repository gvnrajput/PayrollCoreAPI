using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsBankBranch
{
    public int BankBranchId { get; set; }

    public int? BankId { get; set; }

    public string? BranchName { get; set; }

    public string? BranchAddress { get; set; }

    public string? Ifscno { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PhoneNo { get; set; }

    public string? Fax { get; set; }

    public string? EmailId { get; set; }

    public bool? BranchActive { get; set; }

    public virtual SettingsBank? Bank { get; set; }
}
