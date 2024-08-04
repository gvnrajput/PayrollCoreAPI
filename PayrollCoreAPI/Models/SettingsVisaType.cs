using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsVisaType
{
    public int VisaTypeId { get; set; }

    public string? VisaType { get; set; }

    public bool? VisaTypeStatusActive { get; set; }
}
