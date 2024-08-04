using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class ViewResignedEmployeeRanchi
{
    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public string? EmployeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? Dob { get; set; }

    public string? Gender { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DesignationName { get; set; }

    public string? ResignSubmitted { get; set; }

    public string? ResignationReason { get; set; }
}
