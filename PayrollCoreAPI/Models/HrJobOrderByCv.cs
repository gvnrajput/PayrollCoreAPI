using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrJobOrderByCv
{
    public int JobOrderByCvid { get; set; }

    public int? ManpowerRequisationId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? JobOrderByCvactive { get; set; }
}
