using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollSalaryHeaderFaf
{
    public int SalaryHeaderId { get; set; }

    public int? AttendanceId { get; set; }

    public int? MonthId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? IsLocked { get; set; }

    public bool? SalaryHeaderActive { get; set; }

    public bool? SalaryVerified { get; set; }

    public bool? EntitlementVerified { get; set; }

    public bool? IncentiveVerified { get; set; }
}
