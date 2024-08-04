using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstEmployeeRating
{
    public int RatingId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ManagerId { get; set; }

    public int? BranchId { get; set; }

    public string? Finyear { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? MonthId { get; set; }
}
