﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MstTemplateType
{
    public int TemplateId { get; set; }

    public string? TemplateType { get; set; }

    public bool? IsActive { get; set; }
}
