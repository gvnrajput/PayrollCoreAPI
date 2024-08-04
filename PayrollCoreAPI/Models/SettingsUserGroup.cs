using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsUserGroup
{
    public int UserGroupId { get; set; }

    public string? UserGroupName { get; set; }

    public bool? UserGroupActive { get; set; }

    public virtual ICollection<SettingsUser> SettingsUsers { get; set; } = new List<SettingsUser>();
}
