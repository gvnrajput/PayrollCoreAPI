using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LeaveOpening
{
    public int LeaveOpeningId { get; set; }

    public int? LeaveTypeId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? LeaveOpening1 { get; set; }

    public int? LeaveYear { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LeaveOpeningActive { get; set; }

    public decimal? YearlyAnnounceLeave { get; set; }

    public bool? ElencashmentStatus { get; set; }
}
