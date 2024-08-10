using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollSalaryStructure
{
    public int SalaryStructureId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? Value { get; set; }

    public string? ValueBy { get; set; }

    public string? Formula { get; set; }

    public int? HeadSequence { get; set; }

    public bool? Manually { get; set; }

    public int? LocationId { get; set; }

    public int? CompanyId { get; set; }

    public bool? SalaryStructureActive { get; set; }
}
