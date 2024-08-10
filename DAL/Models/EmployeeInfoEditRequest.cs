using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeInfoEditRequest
{
    public int RequestId { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? FatherName { get; set; }

    public string? MobileNo { get; set; }

    public DateTime? Dob { get; set; }

    public string? EmailId { get; set; }

    public string? PanNo { get; set; }

    public string? BloodGroup { get; set; }

    public string? PrresentAddress { get; set; }

    public string? PermanentAddress { get; set; }

    public string? MaritalStatus { get; set; }

    public bool? Status { get; set; }

    public string? ImgUrl { get; set; }
}
