using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CvrepositoryCvtype
{
    public int CvtypeId { get; set; }

    public string? Cvtype { get; set; }

    public string? Cvdescription { get; set; }

    public bool? CvtypeActive { get; set; }
}
