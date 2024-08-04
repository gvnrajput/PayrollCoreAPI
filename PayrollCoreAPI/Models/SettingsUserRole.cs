using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsUserRole
{
    public int UserRoleId { get; set; }

    public int? UserId { get; set; }

    public int? ModuleId { get; set; }

    public int? FormId { get; set; }

    public bool? Uread { get; set; }

    public bool? Uwrite { get; set; }

    public bool? Umodify { get; set; }

    public bool? Udelete { get; set; }

    public bool? Uprint { get; set; }

    public bool? Uapproval { get; set; }

    public bool? IsPermission { get; set; }

    public bool? UserRoleActive { get; set; }

    public virtual SettingsForm? Form { get; set; }

    public virtual SettingsModule? Module { get; set; }
}
