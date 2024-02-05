#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogRegApp.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter your username")]
    [MinLength(3, ErrorMessage =" Plase enter a Valid username")]
    public string Username { get; set; }

    [Required(ErrorMessage = " please enter your email")]
    [EmailAddress(ErrorMessage = "please enter a valid email address")]
    public string Email { get; set; }

    [Required(ErrorMessage =" please enter your password")]
    [MinLength(6, ErrorMessage =" Plase enter a Valid password")]
    public string Password { get; set; }

    [NotMapped]
    [Required(ErrorMessage =" please enter your password")]
    [MinLength(6, ErrorMessage =" Plase enter a Valid password")]
    [Compare("Password", ErrorMessage = "Passwords must match .")]
    [Display(Name = "Confirm PW")]
    public string ConfirmPW { get; set; }


    [Required]
    [Display(Name = "Do You want to subscribe to our newsletter ?")]
    public bool IsSubscribed { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}