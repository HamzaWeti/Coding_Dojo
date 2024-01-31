using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models;
public class User
{
    [Required]
    [MinLength(3)]
    public string Name{ get; set; }
    [Required]
    [EmailAddress]
    public string Email{get; set;}
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [Display(Name ="Number")]
    public int PhoneNumber { get; set; }
}