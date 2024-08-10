using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCompanyAccount
{
    public int CompanyAccountId { get; set; }

    public int? BankId { get; set; }

    public int? BankBranchId { get; set; }

    public string? AccountNo { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? CompanyAccountActive { get; set; }
}
