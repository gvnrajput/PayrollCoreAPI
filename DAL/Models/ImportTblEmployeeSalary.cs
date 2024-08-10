using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ImportTblEmployeeSalary
{
    public string? EmployeCode { get; set; }

    public decimal? BasicSalary { get; set; }

    public decimal? Hra { get; set; }

    public decimal? Conveyance { get; set; }

    public decimal? SpecialAllowance { get; set; }

    public decimal? Pf { get; set; }

    public decimal? Pfemployer { get; set; }

    public decimal? Esic { get; set; }

    public decimal? Gratuity { get; set; }

    public decimal? Esicemployer { get; set; }
}
