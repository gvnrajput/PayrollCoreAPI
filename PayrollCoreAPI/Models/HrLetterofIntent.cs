using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrLetterofIntent
{
    public int LetterofIntentId { get; set; }

    public string? LetterofIntentCode { get; set; }

    public DateTime? IssuDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? WorkingHours { get; set; }

    public string? Remarks { get; set; }

    public int? NoOfTimesPrint { get; set; }

    public string? PrintDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? LetterofIntentActive { get; set; }

    public int? CvuploadId { get; set; }

    public int? ManpowerRequisationId { get; set; }
}
