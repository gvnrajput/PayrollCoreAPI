using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblResignedEmployee
{
    public int ResignedEmployeeId { get; set; }

    public string? EmployeCode { get; set; }

    public string? EmployeName { get; set; }

    public DateTime? ResignationDate { get; set; }

    public string? ResignationReason { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
