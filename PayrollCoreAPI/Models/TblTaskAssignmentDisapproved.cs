using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class TblTaskAssignmentDisapproved
{
    public int DisapprovedId { get; set; }

    public int? TaskAssignmentId { get; set; }

    public DateTime? DisapprovedDate { get; set; }

    public string? Remark { get; set; }

    public string? RemarkByManager { get; set; }
}
