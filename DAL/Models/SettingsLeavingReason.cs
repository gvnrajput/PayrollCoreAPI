﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsLeavingReason
{
    public int LeavingReasonId { get; set; }

    public string? LeavingReason { get; set; }

    public bool? LeavingReasonActive { get; set; }
}
