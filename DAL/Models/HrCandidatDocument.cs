using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrCandidatDocument
{
    public int DocumentId { get; set; }

    public int? CandidateId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? DocumentPath { get; set; }
}
