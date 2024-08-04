using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidatDocument
{
    public int DocumentId { get; set; }

    public int? CandidateId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentPath { get; set; }
}
