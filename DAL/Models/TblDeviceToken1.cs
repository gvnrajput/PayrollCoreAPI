using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblDeviceToken1
{
    public int DeviceTokenId { get; set; }

    public int? EmployeeId { get; set; }

    public string? DeviceToken { get; set; }
}
