using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblTroubleTicket
{
    public int TroubleTicketId { get; set; }

    public int? EmployeeId { get; set; }

    public int? DepartmentFrom { get; set; }

    public int? DepartmentId { get; set; }

    public int? QuerryId { get; set; }

    public DateTime? EstimatedTime { get; set; }

    public int? Status { get; set; }

    public bool? IsActiveStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? SolvedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? SolvedBy { get; set; }

    public string? Remark { get; set; }
}
