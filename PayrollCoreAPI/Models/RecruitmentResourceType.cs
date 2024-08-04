using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class RecruitmentResourceType
{
    public int ResourceTypeId { get; set; }

    public string? ResourceType { get; set; }

    public string? ResourceDescription { get; set; }

    public bool? ResourceTypeActive { get; set; }
}
