using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class PayrollElencashment
{
    public int ElencashmentId { get; set; }

    public int? EmployeeId { get; set; }

    public int? LeaveTypeId { get; set; }

    public int? LeaveYear { get; set; }

    public DateTime? EncashDate { get; set; }

    public decimal? Elopeninig { get; set; }

    public decimal? CurrentYearLeave { get; set; }

    public decimal? UsedLeave { get; set; }

    public decimal? BalanceLeave { get; set; }

    public decimal? EncashLeave { get; set; }

    public decimal? EncashAmount { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? ElencashmentActive { get; set; }

    public int? FinancialYearId { get; set; }
}
