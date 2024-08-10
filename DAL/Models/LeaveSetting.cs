using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LeaveSetting
{
    public int LeaveSettingId { get; set; }

    public string? LeaveApplicableOn { get; set; }

    public bool? LeaveSettingActive { get; set; }
}
