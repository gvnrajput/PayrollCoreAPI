using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeAssetDetail
{
    public int EmployeeAssetId { get; set; }

    public int? EmployeeId { get; set; }

    public int? AssetId { get; set; }

    public string? AssetCode { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? IssueBy { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public string? Remarks { get; set; }

    public bool? Status { get; set; }

    public bool? EmployeeAssetActive { get; set; }
}
