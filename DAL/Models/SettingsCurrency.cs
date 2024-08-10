using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SettingsCurrency
{
    public int CurrencyId { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrencyName { get; set; }

    public bool? CurrencyActive { get; set; }
}
