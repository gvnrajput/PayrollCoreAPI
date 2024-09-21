namespace WebAPI.Models
{
    public class SettingsStateWithCountry
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public bool? StateActive { get; set; }
        public string CountryName { get; set; }
    }
}
