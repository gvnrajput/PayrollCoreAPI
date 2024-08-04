using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class HrCandidateAddressDetail
{
    public decimal AddressDetailId { get; set; }

    public int? CandidateId { get; set; }

    public string? AddressType { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public int? PinCode { get; set; }

    public string? PhoneNo { get; set; }

    public int? Ext { get; set; }

    public string? FaxNo { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }
}
