#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models;

public class Survey
{
      [Required]
    public string name { get; set; }
      [Required]
    public string location { get; set; }
      [Required]
    public string language { get; set; }
      [Required]
    public string comment { get; set; }
}