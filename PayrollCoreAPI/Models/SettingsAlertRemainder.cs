using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsAlertRemainder
{
    public int AlertRemainderId { get; set; }

    public string? AlertReminder { get; set; }

    public int? NoOfdays { get; set; }

    public bool? Status { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? AlertRemainderActive { get; set; }
}
