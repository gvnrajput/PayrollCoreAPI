using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstRatingParameter
{
    public int ParameterId { get; set; }

    public string ParameterName { get; set; } = null!;

    public int? BranchId { get; set; }
}
