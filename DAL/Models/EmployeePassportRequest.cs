using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeePassportRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public string? IqamaNo { get; set; }

    public string? PassportNo { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? VisaNo { get; set; }

    public int? VisaType { get; set; }

    public int? Status { get; set; }
}
