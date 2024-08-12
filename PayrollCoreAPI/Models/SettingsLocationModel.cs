using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class SettingsLocationModel
    {
        [Required(ErrorMessage = "Location name is required.")]
        [StringLength(100, ErrorMessage = "Location name can't be longer than 100 characters.")]
        public string? LocationName { get; set; }

        [StringLength(200, ErrorMessage = "Location address can't be longer than 200 characters.")]
        public string? LocationAddress { get; set; }

        public int? CityId { get; set; }

        public int? StateId { get; set; }

        public int? CountryId { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string? PhoneNo { get; set; }

        public string? Fax { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? EmailId { get; set; }

        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Location active status is required.")]
        public bool? LocationActive { get; set; }

        public int? CompanyId { get; set; }
    }
}
