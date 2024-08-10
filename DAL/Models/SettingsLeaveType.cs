using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsLeaveType
{
    public int LeaveTypeId { get; set; }

    public string? LeaveType { get; set; }

    public string? LeaveDescription { get; set; }

    public bool? LeaveTypeActive { get; set; }
}
