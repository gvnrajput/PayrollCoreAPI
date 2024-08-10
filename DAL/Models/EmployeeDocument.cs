using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeDocument
{
    public int DocumentId { get; set; }

    public int? EmployeeId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentPath { get; set; }

    public bool? VerifyStatus { get; set; }

    public DateTime? DocumentDate { get; set; }
}
