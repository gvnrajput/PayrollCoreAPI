using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsHoliday
{
    public int HolidayId { get; set; }

    public string? HolidayName { get; set; }

    public DateTime? HolidayDate { get; set; }

    public DateTime? HolidayDateTo { get; set; }

    public bool? IsRestricted { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? HolidayActive { get; set; }
}
