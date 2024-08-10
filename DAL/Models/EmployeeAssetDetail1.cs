using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeAssetDetail1
{
    public int AssetDetailsId { get; set; }

    public int? EmployeeId { get; set; }

    public int? AssetId { get; set; }

    public int? AssetQty { get; set; }

    public DateTime? AssetValidUpto { get; set; }

    public string? AssetRemarks { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
