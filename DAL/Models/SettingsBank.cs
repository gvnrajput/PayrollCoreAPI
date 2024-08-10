using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsBank
{
    public int BankId { get; set; }

    public string? BankName { get; set; }

    public bool? BankActive { get; set; }

    public virtual ICollection<SettingsBankBranch> SettingsBankBranches { get; set; } = new List<SettingsBankBranch>();
}
