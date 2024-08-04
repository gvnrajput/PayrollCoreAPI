using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Smshistory
{
    public decimal SmshistoryId { get; set; }

    public int? EmployeeId { get; set; }

    public string? TemplateType { get; set; }

    public string? Message { get; set; }

    public string? MobileNo { get; set; }

    public string? MessageId { get; set; }

    public string? Status { get; set; }

    public bool? SmshistoryActive { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
