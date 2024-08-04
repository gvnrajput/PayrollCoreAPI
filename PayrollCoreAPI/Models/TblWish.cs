using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class TblWish
{
    public int WishId { get; set; }

    public string? SentBy { get; set; }

    public string? SentTo { get; set; }

    public string? WishFor { get; set; }

    public string? Message { get; set; }

    public DateTime? Date { get; set; }

    public int? ReadStatus { get; set; }
}
