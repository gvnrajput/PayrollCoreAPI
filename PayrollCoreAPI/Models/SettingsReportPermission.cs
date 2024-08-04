using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsReportPermission
{
    public int PermissionId { get; set; }

    public int? UserId { get; set; }

    public int? FormId { get; set; }

    public string? ReportName { get; set; }

    public string? AccordianId { get; set; }

    public int? ReportPermissionId { get; set; }

    public bool? IsPermission { get; set; }

    public bool? IsActive { get; set; }
}
