using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsExperience
{
    public int ExperienceId { get; set; }

    public string? ExperienceName { get; set; }

    public bool? ExperienceActive { get; set; }
}
