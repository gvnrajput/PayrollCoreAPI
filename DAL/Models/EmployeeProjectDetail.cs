using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeProjectDetail
{
    public long ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? Party { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ApproxEndDate { get; set; }
}
