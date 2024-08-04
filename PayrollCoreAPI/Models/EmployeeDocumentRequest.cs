using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class EmployeeDocumentRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentPath { get; set; }

    public int? Status { get; set; }
}
