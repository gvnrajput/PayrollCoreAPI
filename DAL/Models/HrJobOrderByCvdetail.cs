using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrJobOrderByCvdetail
{
    public int JobOrderByCvdetailsId { get; set; }

    public int? JobOrderByCvid { get; set; }

    public int? CvuploadId { get; set; }

    public string? ResumePath { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
