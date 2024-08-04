using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class OrganisationTree
{
    public int OrgTreeId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ManagerId { get; set; }

    public int? CompanyId { get; set; }

    public int? LocationId { get; set; }

    public bool? OrgTreeActive { get; set; }
}
