﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class SettingsDocumentType
{
    public int DocumentTypeId { get; set; }

    public string? DocumentTypeName { get; set; }

    public bool? DocumentTypeActive { get; set; }
}
