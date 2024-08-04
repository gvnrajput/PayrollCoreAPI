using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class DataLog
{
    public int DataLogId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? PkId { get; set; }

    public int? ActionType { get; set; }

    public string? ActionDescription { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ClassName { get; set; }

    public string? TableName { get; set; }

    public int? UserId { get; set; }

    public string? IpAdress { get; set; }
}
