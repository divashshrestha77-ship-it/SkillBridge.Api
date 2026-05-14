using System.ComponentModel.DataAnnotations;

public class UserProfile
{
    [Required, Key]
    public string id { get; set; }
    [Required]
    public string Experience { get; set; }
    public string LinkedInProfile { get; set; }
    public string GitHubProfile { get; set; }
    [Required]
    public string Education { get; set; }
    [Required]
    public string Bio { get; set; }
    [Required]
    public string ContactNumber { get; set; }
    [Required]
    public string Location { get; set; }

}