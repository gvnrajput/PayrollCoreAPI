using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsLoan
{
    public decimal LoanId { get; set; }

    public string LoanCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool? IsActiveStatus { get; set; }
}
