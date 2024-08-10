using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsForm
{
    public int FormId { get; set; }

    public int? ModuleId { get; set; }

    public string? FormName { get; set; }

    public string? FormUrl { get; set; }

    public int? FormSequence { get; set; }

    public string? Description { get; set; }

    public bool? FormActive { get; set; }

    public virtual SettingsModule? Module { get; set; }

    public virtual ICollection<SettingsUserRole> SettingsUserRoles { get; set; } = new List<SettingsUserRole>();
}
