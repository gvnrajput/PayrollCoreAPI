using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingSm
{
    public int SmsSettingId { get; set; }

    public string? Url { get; set; }

    public string? Uid { get; set; }

    public string? Upassword { get; set; }

    public string? Remarks { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? LocationId { get; set; }

    public string? UserName { get; set; }
}
