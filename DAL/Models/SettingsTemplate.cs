using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsTemplate
{
    public int TemplateSettingId { get; set; }

    public string? TemplateType { get; set; }

    public string? TemplateText { get; set; }

    public string? Remarks { get; set; }

    public string? TemplateFor { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? TemplateActive { get; set; }
}
