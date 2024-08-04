using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class AttendanceShiftDetail
{
    public int ShiftDetailId { get; set; }

    public int? ShiftId { get; set; }

    public string? VDayName { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public bool? VsatDayStatus { get; set; }
}
