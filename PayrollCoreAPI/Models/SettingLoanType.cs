using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingLoanType
{
    public int LoanTypeId { get; set; }

    public string? LoanType { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LoanTypeActive { get; set; }
}
