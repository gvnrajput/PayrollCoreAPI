using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MstPermission
{
    public int PermissionId { get; set; }

    public string? PermissionFor { get; set; }

    public int? NoOfRights { get; set; }
}
