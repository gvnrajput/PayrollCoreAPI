using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Smssetting
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public string? EmailId { get; set; }

    public string? WorkFlow { get; set; }

    public bool? Aplicable { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpatedBy { get; set; }

    public DateTime? UpateDate { get; set; }

    public bool? IsActiveStaus { get; set; }
}
