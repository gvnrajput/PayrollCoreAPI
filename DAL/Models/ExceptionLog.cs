using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ExceptionLog
{
    public int Id { get; set; }

    public string? ExceptionMessage { get; set; }

    public string? StackTrace { get; set; }

    public string? ExceptionType { get; set; }

    public DateTime? DateOccurred { get; set; }
}
