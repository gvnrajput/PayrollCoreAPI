﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollCategoryType
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public bool? CategoryActive { get; set; }
}
