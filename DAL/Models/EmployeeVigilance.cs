using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeVigilance
{
    public int EmployeeVigillanceId { get; set; }

    public int? EmployeeId { get; set; }

    public int? VigilanceId { get; set; }

    public string? ActionType { get; set; }

    public DateTime? WarningDate { get; set; }

    public string? DocPath { get; set; }

    public DateTime? MistakeDate { get; set; }

    public int? NoticeByEmployee { get; set; }

    public string? MistakePlace { get; set; }

    public string? Remarks { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? EmployeeVigilanceActive { get; set; }
}
