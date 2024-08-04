using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class TblEmployeeRating
{
    public int TblRatingId { get; set; }

    public int? RatingId { get; set; }

    public int? ParameterId { get; set; }

    public decimal? Rating { get; set; }

    public int? BranchId { get; set; }

    public string? Finyear { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
