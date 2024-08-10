using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MstStatusClaim
{
    public int StatusClaimId { get; set; }

    public string? Name { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
