using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class EmployeeAddressDetail
{
    public int AddressDetailId { get; set; }

    public int? EmployeeId { get; set; }

    public string? AddressType { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? PinCode { get; set; }

    public string? PhoneNo { get; set; }

    public string? Ext { get; set; }

    public string? FaxNo { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public bool? VerifyStatus { get; set; }

    public int? ZoneId { get; set; }
}
