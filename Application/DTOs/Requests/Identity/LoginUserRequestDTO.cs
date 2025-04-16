using System.ComponentModel.DataAnnotations;

namespace IMS.Application.DTOs.Requests.Identity;

public class LoginUserRequestDTO
{
    [EmailAddress]
    [Required]
    [RegularExpression("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+", ErrorMessage = "Your Email is not valid")]
    public string Email { get; set; }

    [Required]
    [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$", ErrorMessage = "Your password must Contains atleast one Captal character, small case character, number and special character")]
    [MinLength(8), MaxLength(100)]
    public string Password { get; set; }
}