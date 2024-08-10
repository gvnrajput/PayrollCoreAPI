using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeToDoStatusLog
{
    public long EmployeeToDoStatusId { get; set; }

    public long? EmployeeToDoId { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? CreatedBy { get; set; }
}
