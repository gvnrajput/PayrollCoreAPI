using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoginDetail
{
    public int LoginId { get; set; }

    public int? UserId { get; set; }

    public string? LogStatus { get; set; }

    public DateOnly? LogDate { get; set; }

    public TimeOnly? LogInTime { get; set; }

    public TimeOnly? LogOutTime { get; set; }

    public string? IpAdress { get; set; }

    public int? CurrentStatus { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
