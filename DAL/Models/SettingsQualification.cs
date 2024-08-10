using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsQualification
{
    public int QualificationId { get; set; }

    public string? Qualification { get; set; }

    public bool? QualificationActive { get; set; }
}
