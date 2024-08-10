using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingSmsaccount
{
    public decimal SmsaccountId { get; set; }

    public DateTime? StartDate { get; set; }

    public int? Smslimit { get; set; }

    public int? DaysLimit { get; set; }

    public bool? SmsaccountActive { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }
}
