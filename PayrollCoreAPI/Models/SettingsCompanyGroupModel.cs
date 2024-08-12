using System.ComponentModel.DataAnnotations;

public class SettingsCompanyGroupModel
{
    [Required(ErrorMessage = "Company Group Name is required.")]
    [StringLength(100, ErrorMessage = "Company Group Name can't be longer than 100 characters.")]
    public string CompanyGroupName { get; set; }
    public bool? CompanyGroupActive { get; set; }
}
