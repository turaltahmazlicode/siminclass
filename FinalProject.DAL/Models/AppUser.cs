
namespace FinalProject.DAL.Models;
public class AppUser : IdentityUser
{
    [Required]
    [MinLength(2), MaxLength(30)]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2), MaxLength(40)]
    public string LastName { get; set; }
}
