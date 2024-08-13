using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class SettingsUserModel
    {
        public int UserId { get; set; }

        [Required]
        public int? UserGroupId { get; set; }

        public int? CompanyId { get; set; }

        public int? LocationId { get; set; }

        public int? EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool? UserActive { get; set; }
    }
}
