using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeePromotion
{
    public int PromotionId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? PromotionDate { get; set; }

    public int? PrevDepartmentId { get; set; }

    public int? PrevDesignationId { get; set; }

    public decimal? PrevSalary { get; set; }

    public int? ChangedDepartmentId { get; set; }

    public int? ChangeDesignationId { get; set; }

    public decimal? ChangedSalary { get; set; }

    public string? Remarks { get; set; }

    public string? PromotionStatus { get; set; }

    public int? FinYearId { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? PromotionActive { get; set; }
}
