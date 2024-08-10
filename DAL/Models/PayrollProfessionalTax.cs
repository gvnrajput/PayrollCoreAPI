using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PayrollProfessionalTax
{
    public int ProfessionalTaxId { get; set; }

    public int? StateId { get; set; }

    public decimal? AmountFrom { get; set; }

    public decimal? AmountTo { get; set; }

    public decimal? AmountPayable { get; set; }

    public bool? ProfessionalTaxActive { get; set; }
}
