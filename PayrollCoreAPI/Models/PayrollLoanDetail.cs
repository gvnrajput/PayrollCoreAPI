using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollLoanDetail
{
    public int LoanDetailId { get; set; }

    public int? LoanId { get; set; }

    public DateTime? InstDate { get; set; }

    public decimal? InstAmount { get; set; }

    public bool? IsGiven { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? CancelledDate { get; set; }

    public int? CanceldBy { get; set; }
}
