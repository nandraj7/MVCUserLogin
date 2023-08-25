using System.ComponentModel.DataAnnotations;

namespace MVCUserLogin.Models
{
    public class AddViewModel
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        [RegularExpression(@"^(?:(?:\+|0{0,2})91(\s*[\ -]\s*)?|[0]?)?[789]\d{9}|(\d[ -]?){10}\d$", ErrorMessage = "Mobile Number isn't Valid")]
        public string? MobileNumber { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password Should be Minimum 8 Characters and Maximum 20")]
        public string? Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Password is not Matching")]
        public string? ConfirmPassword { get; set; }
    }
}
