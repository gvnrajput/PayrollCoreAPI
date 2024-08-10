using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RecruitmentTradeCategoryType
{
    public int TradeCategoryTypeId { get; set; }

    public int? ResourceTypeId { get; set; }

    public string? TradeCategoryType { get; set; }

    public string? TradeCategoryDescription { get; set; }

    public bool? TradeCategoryTypeActive { get; set; }

    public int? CvtypeId { get; set; }
}
