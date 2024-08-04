using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeToDoTaskMst
{
    public long EmployeeToDoId { get; set; }

    public long? ProjectId { get; set; }

    public string? Task { get; set; }

    public string? Description { get; set; }

    public DateTime? AllocationDate { get; set; }

    public string? AllocatedTime { get; set; }

    public long? EmployeeId { get; set; }

    public int? CurrentStatus { get; set; }

    public DateTime? StartDate { get; set; }
}
