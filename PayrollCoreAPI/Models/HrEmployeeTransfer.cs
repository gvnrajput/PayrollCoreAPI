using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrEmployeeTransfer
{
    public int EmployeeTransferId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? Remarks { get; set; }

    public int? FromLocationId { get; set; }

    public int? TolocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? FinancialYearId { get; set; }

    public int? SalaryGradeId { get; set; }

    public bool? EmployeeTransferActive { get; set; }

    public int? FromSalaryGradeId { get; set; }

    public int? FromZoneId { get; set; }

    public int? ToZoneId { get; set; }
}
