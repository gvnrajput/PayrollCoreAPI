using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsQuerry
{
    public int QuerryId { get; set; }

    public string? Querry { get; set; }

    public int? DepartmentId { get; set; }

    public string? EstimateType { get; set; }

    public int? EstimatedTime { get; set; }

    public bool? QuerryActive { get; set; }
}
