using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstRembursementType
{
    public int RembursementTypeId { get; set; }

    public string? Name { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
