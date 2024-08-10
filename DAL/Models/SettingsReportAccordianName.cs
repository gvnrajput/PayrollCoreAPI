using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsReportAccordianName
{
    public int ReportPermissionId { get; set; }

    public int? FormId { get; set; }

    public string? AccordianId { get; set; }

    public string? ReportFor { get; set; }

    public bool? IsActive { get; set; }
}
