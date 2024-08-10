using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrAppointmentLetter
{
    public int AppointmentLetterId { get; set; }

    public string? AppointmentLetterCode { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? IssuDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    public string? WorkingHours { get; set; }

    public string? Remarks { get; set; }

    public int? NoOfTimesPrint { get; set; }

    public string? PrintDate { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? AppointmentLetterActive { get; set; }

    public int? CvuploadId { get; set; }
}
