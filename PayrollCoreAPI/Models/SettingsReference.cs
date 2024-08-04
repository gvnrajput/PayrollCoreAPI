using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsReference
{
    public int ReferenceId { get; set; }

    public string? ReferenceName { get; set; }

    public bool? ReferenceActive { get; set; }
}
