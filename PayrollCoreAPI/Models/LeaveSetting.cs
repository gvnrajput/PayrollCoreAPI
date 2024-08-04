using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class LeaveSetting
{
    public int LeaveSettingId { get; set; }

    public string? LeaveApplicableOn { get; set; }

    public bool? LeaveSettingActive { get; set; }
}
