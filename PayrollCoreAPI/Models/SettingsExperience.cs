using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsExperience
{
    public int ExperienceId { get; set; }

    public string? ExperienceName { get; set; }

    public bool? ExperienceActive { get; set; }
}
