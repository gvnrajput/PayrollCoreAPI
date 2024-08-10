using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsModule
{
    public int ModuleId { get; set; }

    public string? ModuleName { get; set; }

    public int? ModuleSequence { get; set; }

    public string? ModuleIcon { get; set; }

    public string? Description { get; set; }

    public bool? ModuleActive { get; set; }

    public virtual ICollection<SettingsForm> SettingsForms { get; set; } = new List<SettingsForm>();

    public virtual ICollection<SettingsUserRole> SettingsUserRoles { get; set; } = new List<SettingsUserRole>();
}
