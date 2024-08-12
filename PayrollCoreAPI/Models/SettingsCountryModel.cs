using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class SettingsCountryModel
    {   

        [Required(ErrorMessage = "Country name is required.")]
        [StringLength(100, ErrorMessage = "Country name can't be longer than 100 characters.")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Country active status is required.")]
        public bool CountryActive { get; set; }
    }
}
