using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class SettingsCompanyModel
    {
        [Required(ErrorMessage = "Company group ID is required")]
        public int? CompanyGroupId { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [StringLength(100, ErrorMessage = "Company name can't be longer than 100 characters")]
        public string? CompanyName { get; set; }

        [StringLength(250, ErrorMessage = "Company address can't be longer than 250 characters")]
        public string? CompanyAddress { get; set; }

        public int? CityId { get; set; }

        public int? StateId { get; set; }

        public int? CountryId { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PhoneNo { get; set; }

        [Phone(ErrorMessage = "Invalid fax number")]
        public string? Fax { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? EmailId { get; set; }

        [Url(ErrorMessage = "Invalid website URL")]
        public string? Website { get; set; }

        [Url(ErrorMessage = "Invalid image URL")]
        public string? CompanyImgUrl { get; set; }

        public byte[]? CompanyLogo { get; set; }

        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters")]
        public string? Description { get; set; }

        public bool? CompanyActive { get; set; }

        [StringLength(50, ErrorMessage = "Registration number can't be longer than 50 characters")]
        public string? RegNo { get; set; }

        [StringLength(50, ErrorMessage = "PAN number can't be longer than 50 characters")]
        public string? PanNo { get; set; }

        [StringLength(50, ErrorMessage = "TIN number can't be longer than 50 characters")]
        public string? TinNo { get; set; }

        [StringLength(50, ErrorMessage = "ECC number can't be longer than 50 characters")]
        public string? EccNo { get; set; }

        [StringLength(50, ErrorMessage = "CST number can't be longer than 50 characters")]
        public string? CstNo { get; set; }

        [StringLength(100, ErrorMessage = "Collectorate can't be longer than 100 characters")]
        public string? Collectorate { get; set; }

        [StringLength(50, ErrorMessage = "HGST number can't be longer than 50 characters")]
        public string? Hgstno { get; set; }

        [StringLength(50, ErrorMessage = "Service tax number can't be longer than 50 characters")]
        public string? ServiceTaxNo { get; set; }

        [StringLength(50, ErrorMessage = "Excise range can't be longer than 50 characters")]
        public string? ExciseRange { get; set; }

        [StringLength(250, ErrorMessage = "Excise address can't be longer than 250 characters")]
        public string? ExciseAddress { get; set; }

        [StringLength(50, ErrorMessage = "Excise division can't be longer than 50 characters")]
        public string? ExciseDiv { get; set; }

        [StringLength(50, ErrorMessage = "Company license number can't be longer than 50 characters")]
        public string? CompanyLicNo { get; set; }

        [StringLength(100, ErrorMessage = "Primary owner can't be longer than 100 characters")]
        public string? PrimaryOwner { get; set; }
    }
}
