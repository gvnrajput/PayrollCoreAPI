﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsReligion
{
    public int ReligionId { get; set; }

    public string? ReligionName { get; set; }

    public bool? ReligionActive { get; set; }
}
