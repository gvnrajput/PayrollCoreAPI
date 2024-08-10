using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollForm16Head
{
    public int Form16HeadId { get; set; }

    public int? SalaryHeadTypeId { get; set; }

    public string? Form16HeadName { get; set; }

    public string? Description { get; set; }

    public int? ProcessSequence { get; set; }

    public bool? Form16HeadActive { get; set; }
}
