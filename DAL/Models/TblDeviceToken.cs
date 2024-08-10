using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblDeviceToken
{
    public int DeviceTokenId { get; set; }

    public int? EmployeeId { get; set; }

    public string? DeviceToken { get; set; }
}
