using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ImportedAttendance
{
    public int? Sno { get; set; }

    public int? ModeNo { get; set; }

    public int? MachineNo { get; set; }

    public string? CardNo { get; set; }

    public int? EmployeeId { get; set; }

    public int? Iomode { get; set; }

    public DateTime? AttendanceTime { get; set; }

    public DateTime? CurDate { get; set; }

    public string? Reason { get; set; }

    public string? PunchingStatusType { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
