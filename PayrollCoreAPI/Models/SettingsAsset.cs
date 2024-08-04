using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsAsset
{
    public int AssetId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public string? Description { get; set; }

    public bool? AssetActive { get; set; }
}
