﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ViewEmployeeWiseSalaryBihar
{
    public string? EmployeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }

    public string? Designation { get; set; }

    public string? Doj { get; set; }

    public decimal? Salary { get; set; }
}
