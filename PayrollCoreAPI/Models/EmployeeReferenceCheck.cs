using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeReferenceCheck
{
    public int ReferenceCheckId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ReferenceId { get; set; }

    public bool? VerifyStatus { get; set; }

    public DateTime? ReferenceCheckDate { get; set; }
}
