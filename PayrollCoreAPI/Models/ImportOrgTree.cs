using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class ImportOrgTree
{
    public string? EmployeeName { get; set; }

    public string? ManagerName { get; set; }
}
