using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsIuserRole
{
    public int UserIroleId { get; set; }

    public int? UserId { get; set; }

    public int? ModuleId { get; set; }

    public int? FormId { get; set; }

    public bool? Uimport { get; set; }

    public bool? ImportRoleActive { get; set; }
}
