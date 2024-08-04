using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class MstChecklist
{
    public int CheckListId { get; set; }

    public string? Head { get; set; }

    public string? GenerateSequence { get; set; }

    public string? Description { get; set; }

    public bool? ActiveStatus { get; set; }

    public int? Sid { get; set; }
}
