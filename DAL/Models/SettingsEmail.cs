using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsEmail
{
    public int MailSettingId { get; set; }

    public string? MailType { get; set; }

    public string? ServerName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public decimal? PortNo { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? EmailActive { get; set; }
}
