using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingBulletinBoard
{
    public int Id { get; set; }

    public string? MessageType { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? IsActive { get; set; }
}
