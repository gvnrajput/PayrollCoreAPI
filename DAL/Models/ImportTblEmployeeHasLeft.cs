using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ImportTblEmployeeHasLeft
{
    public string? EmployeCode { get; set; }

    public string? EmployeName { get; set; }

    public string? ResignationDate { get; set; }

    public string? ResignationReason { get; set; }
}
