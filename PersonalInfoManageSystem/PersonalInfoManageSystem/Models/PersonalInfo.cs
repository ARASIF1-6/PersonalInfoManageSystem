using System.ComponentModel.DataAnnotations;

namespace PersonalInfoManageSystem.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Address { get; set; }

        [Required]
        public string Nationality { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
