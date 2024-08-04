﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class TblEmployeeHasLeft
{
    public int TblEmployeehasLeftId { get; set; }

    public string? EmployeCode { get; set; }

    public string? EmployeName { get; set; }

    public DateTime? ResignationDate { get; set; }

    public string? ResignationReason { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
