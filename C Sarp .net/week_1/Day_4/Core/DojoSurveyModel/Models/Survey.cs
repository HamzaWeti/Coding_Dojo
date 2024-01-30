#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models;

public class Survey
{
    [Required(ErrorMessage = "should be no less than 2 characters")]
    [MinLength(2)]
    public string name { get; set; }
    [Required]
    public string location { get; set; }
    [Required]
    public string language { get; set; }
    [Required(ErrorMessage = "should be more than 20 characters.")]
    [MinLength(20)]
    public string comment { get; set; }
}