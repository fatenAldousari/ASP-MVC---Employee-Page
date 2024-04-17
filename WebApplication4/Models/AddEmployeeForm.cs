using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class AddEmployeeForm
    {
        [Required]
        public string  Employeeid { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }

    }
}
