using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmailHistory
{
    public decimal EmailHistoryId { get; set; }

    public int? EmployeeId { get; set; }

    public string? TemplateType { get; set; }

    public string? Message { get; set; }

    public string? EmailId { get; set; }

    public string? Status { get; set; }

    public bool? EmailHistoryActive { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
