using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Tempdatum
{
    public string Cardno { get; set; } = null!;

    public DateTime Officepunch { get; set; }

    public string? PDay { get; set; }

    public string? ReasonCode { get; set; }

    public string? ErrorCode { get; set; }

    public string? IdNo { get; set; }

    public string? Process { get; set; }

    public string? DoorTime { get; set; }

    public string? Inout { get; set; }

    public string? Snrno { get; set; }
}
