using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsNationaity
{
    public int NationaityId { get; set; }

    public string? Nationaity { get; set; }

    public bool? NationaityActive { get; set; }
}
