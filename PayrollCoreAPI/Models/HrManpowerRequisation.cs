using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrManpowerRequisation
{
    public int ManpowerRequisationId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DesignationId { get; set; }

    public int? EmployeeStatusId { get; set; }

    public string? Experience { get; set; }

    public string? JobDescription { get; set; }

    public string? Salary { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public string? Jdpath { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? ManpowerRequisationActive { get; set; }

    public string? JobCode { get; set; }

    public bool? Verified { get; set; }

    public int? EmployeeId { get; set; }

    public string? Status { get; set; }

    public string? StatusReason { get; set; }

    public int? UserId { get; set; }

    public DateTime? VerifiedDate { get; set; }
}
