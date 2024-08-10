using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Kraform
{
    public int KraFormId { get; set; }

    public int? EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? DepartmentHead { get; set; }

    public string? Jsresposibilities { get; set; }

    public string? JscasualTask { get; set; }

    public string? PersonSpecification { get; set; }

    public string? Training { get; set; }

    public string? OtherSkill { get; set; }

    public string? FuntionalExternal { get; set; }

    public string? FuntionalInternal { get; set; }

    public string? AccountableFor { get; set; }

    public string? SuccesfullWhen { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public int? IsApproved { get; set; }
}
