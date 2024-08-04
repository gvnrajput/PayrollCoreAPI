using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsMachineConfiguration
{
    public int MachineConfigurationId { get; set; }

    public string? Location { get; set; }

    public int? MachineNo { get; set; }

    public string? MachineType { get; set; }

    public string? Ipaddress { get; set; }

    public int? PortNo { get; set; }

    public int? ComportNo { get; set; }

    public int? Password { get; set; }

    public int? LicenceNo { get; set; }

    public int? CharLength { get; set; }

    public bool? MachineStatus { get; set; }

    public int? CompanyId { get; set; }

    public bool? MachineConfigurationActive { get; set; }
}
