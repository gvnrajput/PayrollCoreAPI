﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstWorkflowType
{
    public int WorkflowId { get; set; }

    public string? WorkflowType { get; set; }

    public bool? IsActive { get; set; }
}
