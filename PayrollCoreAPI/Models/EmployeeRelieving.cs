using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeRelieving
{
    public int RelievingId { get; set; }

    public int? EmployeeId { get; set; }

    public int? DesignationId { get; set; }

    public int? DepartMentId { get; set; }

    public decimal? PrevSalary { get; set; }

    public DateTime? RelievingDate { get; set; }

    public string? Message { get; set; }

    public int? FinYearId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public int? IsActive { get; set; }
}
