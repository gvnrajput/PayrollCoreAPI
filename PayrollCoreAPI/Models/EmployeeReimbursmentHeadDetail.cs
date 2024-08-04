using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeReimbursmentHeadDetail
{
    public int ReimbursmentHeadDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public int? RembursementHeadId { get; set; }

    public decimal? Amount { get; set; }
}
