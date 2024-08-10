using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HrCandidateSalaryHeadDetail
{
    public int CandidateSalaryHeadDetailId { get; set; }

    public int? OfferLetterId { get; set; }

    public int? SalaryStructureId { get; set; }

    public int? SalaryGradeId { get; set; }

    public int? SalaryHeadId { get; set; }

    public decimal? Amount { get; set; }
}
