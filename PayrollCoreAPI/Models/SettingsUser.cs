using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsUser
{
    public int UserId { get; set; }

    public int? UserGroupId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? EmployeeId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? UserActive { get; set; }

    public virtual SettingsUserGroup? UserGroup { get; set; }
}
